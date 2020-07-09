Public Class frmMsAhConProv
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbNoCuenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Dim ahorro As New wrAhorro.wsLibAhorro

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents btnLimpiar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProv1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhConProv))
        Me.btnLimpiar = New MetroFramework.Controls.MetroButton()
        Me.btnProv1 = New MetroFramework.Controls.MetroButton()
        Me.fg2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.cbNoCuenta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(644, 207)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(90, 32)
        Me.btnLimpiar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiar.TabIndex = 198
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseSelectable = True
        Me.btnLimpiar.UseStyleColors = True
        '
        'btnProv1
        '
        Me.btnProv1.Location = New System.Drawing.Point(547, 207)
        Me.btnProv1.Name = "btnProv1"
        Me.btnProv1.Size = New System.Drawing.Size(90, 32)
        Me.btnProv1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProv1.TabIndex = 197
        Me.btnProv1.Text = "Provisiones"
        Me.btnProv1.UseSelectable = True
        Me.btnProv1.UseStyleColors = True
        '
        'fg2
        '
        Me.fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg2.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg2.BackColorBkg = System.Drawing.Color.White
        Me.fg2.BackColorFixed = System.Drawing.Color.Teal
        Me.fg2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg2.ForeColorFixed = System.Drawing.Color.White
        Me.fg2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg2.Location = New System.Drawing.Point(23, 245)
        Me.fg2.Name = "fg2"
        Me.fg2.NodeClosedPicture = Nothing
        Me.fg2.NodeOpenPicture = Nothing
        Me.fg2.OutlineCol = -1
        Me.fg2.Rows = 2
        Me.fg2.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg2.Size = New System.Drawing.Size(711, 364)
        Me.fg2.StyleInfo = resources.GetString("fg2.StyleInfo")
        Me.fg2.TabIndex = 8
        Me.fg2.TreeColor = System.Drawing.Color.DarkGray
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(116, 74)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(134, 24)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(116, 104)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(618, 25)
        Me.txtAsociado.TabIndex = 161
        '
        'cbNoCuenta
        '
        Me.cbNoCuenta.FormattingEnabled = True
        Me.cbNoCuenta.ItemHeight = 24
        Me.cbNoCuenta.Location = New System.Drawing.Point(116, 135)
        Me.cbNoCuenta.Name = "cbNoCuenta"
        Me.cbNoCuenta.Size = New System.Drawing.Size(618, 30)
        Me.cbNoCuenta.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbNoCuenta.TabIndex = 199
        Me.cbNoCuenta.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 171)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 20)
        Me.MetroLabel1.TabIndex = 200
        Me.MetroLabel1.Text = "Fecha Inicial:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(387, 171)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel2.TabIndex = 201
        Me.MetroLabel2.Text = "Fecha Final:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Location = New System.Drawing.Point(116, 171)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(260, 30)
        Me.dtpFechaIni.TabIndex = 202
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(474, 171)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(260, 30)
        Me.dtpFechaFin.TabIndex = 203
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 74)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel3.TabIndex = 204
        Me.MetroLabel3.Text = "DUI:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 101)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel4.TabIndex = 205
        Me.MetroLabel4.Text = "Asociado:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 135)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 20)
        Me.MetroLabel5.TabIndex = 206
        Me.MetroLabel5.Text = "Cuenta:"
        '
        'frmMsAhConProv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(767, 725)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbNoCuenta)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnProv1)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.fg2)
        Me.Controls.Add(Me.txtDui)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhConProv"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Provisiones de Interés"
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Private Sub txtNoCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.LostFocus

    '    Try
    '        Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
    '        Dim oAsoc As New wrAsociados.wsLibAsoc
    '        oPrest = New wrAhorro.wsLibAhorro

    '        If Me.txtNoCuenta.Text.Trim = "" Or Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub

    '        ds = oPrest.ConsultarCuentaAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            dr = ds.Tables(0).Rows(0)
    '            Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
    '            Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
    '            Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
    '            Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
    '            Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
    '            Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
    '            ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,ApellidoCas,Nombres", "Dui='" & Me.txtDui.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
    '            dr = ds.Tables("Cat_Asociados").Rows(0)
    '            Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombres")), "", dr("Nombres")) & " " & IIf(IsDBNull(dr("Apellido1")), "", dr("Apellido1")) & " " & IIf(IsDBNull(dr("Apellido2")), "", dr("Apellido2"))
    '        End If
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub txtNoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress

    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then

    '        Try
    '            Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
    '            Dim oAsoc As New wrAsociados.wsLibAsoc
    '            oPrest = New wrAhorro.wsLibAhorro

    '            If Me.txtNoCuenta.Text.Trim = "" Or Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub

    '            ds = oPrest.ConsultarCuentaAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '            If ds.Tables(0).Rows.Count > 0 Then
    '                dr = ds.Tables(0).Rows(0)
    '                Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
    '                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
    '                Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
    '                Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
    '                Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
    '                Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
    '                ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,ApellidoCas,Nombres", "Dui='" & Me.txtDui.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
    '                dr = ds.Tables(0).Rows(0)
    '                Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombres")), "", dr("Nombres")) & " " & IIf(IsDBNull(dr("Apellido1")), "", dr("Apellido1")) & " " & IIf(IsDBNull(dr("Apellido2")), "", dr("Apellido2"))
    '            End If
    '        Catch ex As Exception
    '           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '        End Try

    '    End If

    'End Sub

    Private Sub frmMsAhConProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDui.Focus()
    End Sub

    'Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick

    '    Dim ofrm As New frmAGenerico
    '    Try
    '        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
    '        ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)<>'1'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
    '        ofrm.Text = "Buscar Tipos de Ahorro"
    '        ofrm.Datos = ds
    '        ofrm.ColSeleccion = 0
    '        ofrm.RefrescarGrid()
    '        ofrm.ShowDialog()
    '        txtCodTipoAhorro.Text = ofrm.Resultado.Trim
    '        If ofrm.Resultado.Trim = "" Then Exit Sub
    '        txtTipoAhorro.Text = ofrm.Resultado2.Trim
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub txtDui_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDui.Validating

        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Text.Trim
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    llenarNoCuenta()
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    llenarNoCuenta()
                    'Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub llenarNoCuenta()
        Dim dts As New DataSet
        dts = ahorro.ConsultarCuentaAhorro("NoCuenta", "Dui='" & Me.txtDui.Value & "' and Left(CodTipoAhorro,1)<>'1' ", "NoCuenta", sUsuario, sPassword, sSucursal)
        Me.cbNoCuenta.DisplayMember = "NoCuenta"
        Me.cbNoCuenta.ValueMember = "NoCuenta"
        Me.cbNoCuenta.DataSource = dts.Tables(0)
    End Sub
    'Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
    '    Dim frm As New frmAGenerico
    '    Dim sTexto As String
    '    frm.Text = "Buscar Cuenta"
    '    Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
    '    Try
    '        oAh = New wrAhorro.wsLibAhorro
    '        ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,Saldo_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and Left(CodTipoAhorro,1)<>'1' and CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '        frm.Datos = ds
    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim = "" Then

    '        ElseIf frm.Resultado.Trim <> "" Then

    '            sTexto = frm.Resultado3.Trim
    '            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,Saldo_CuentaAhorro,SaldoInteresPendiente,Monto", "NoCuenta='" & sTexto.Trim & "' and CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '            If ds.Tables(0).Rows.Count > 0 Then
    '                dr = ds.Tables("AhCuentasAhorro").Rows(0)
    '                Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
    '                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
    '                Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
    '                Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
    '                Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
    '                Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
    '            End If
    '        End If
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow, sTexto As String
                sTexto = Me.txtDui.Text.Trim
                If sTexto = "" Then      'Filtrar Registros
                ElseIf sTexto <> "" Then
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtDui.Value = Trim(dr("DUI"))
                        Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                        llenarNoCuenta()
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    'Private Sub txtCodTipoAhorro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.LostFocus

    '    If Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub
    '    Try
    '        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow
    '        ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and left(CodTipoAhorro,1)<>'1'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            dr = ds.Tables(0).Rows(0)
    '            txtCodTipoAhorro.Text = dr("CodTipoAhorro")
    '            txtTipoAhorro.Text = dr("Descripcion")
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnProv1_Click(sender As Object, e As EventArgs) Handles btnProv1.Click
        Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
        Try
            oPrest = New wrAhorro.wsLibAhorro
            ds = oPrest.ConsultarProvisiones("correlativo,nocuenta,fecha,round(saldo,2) [Saldo],TasaInteres,round(interes,2) [InteresDiario],ROUND(InteresPendiente,2) [interesAcumulado] ", " NoCuenta='" & cbNoCuenta.SelectedValue & "' and Fecha>='" & Me.dtpFechaIni.Value.ToShortDateString & "' and Fecha<='" & Me.dtpFechaFin.Value.ToShortDateString & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            fg2.DataSource = ds.Tables("AhProvisiones")
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            Dim ds As New DataSet
            Me.txtDui.Text = ""
            Me.txtDui.Value = ""
            Me.txtAsociado.Text = ""
            Me.cbNoCuenta.DataSource = Nothing
            'Me.txtNoSocio.Text = ""
            'Me.txtNoCuenta.Text = ""
            'Me.txtCodTipoAhorro.Text = ""
            'Me.txtTipoAhorro.Text = ""
            'Me.txtMonto.Value = 0
            'Me.txtSaldo.Value = 0
            'Me.txtIntPag.Value = 0
            fg2.DataSource = ds
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhConProv_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class