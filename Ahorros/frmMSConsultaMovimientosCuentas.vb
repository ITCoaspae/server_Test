Public Class frmMSConsultaMovimientosCuentas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    'Private vTipoCuenta As Ahorros.clsAhorro.TipoCuenta
    Private vTipoCuenta As sifLib.Ahorro.clsAhorros.TipoCuenta
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbCuentas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Private ahorros As New wrAhorro.wsLibAhorro

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
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSConsultaMovimientosCuentas))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbCuentas = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:19;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(23, 241)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(712, 210)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(634, 203)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(99, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 13
        Me.MetroButton1.Text = "Limpiar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(473, 203)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(155, 32)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Mostrar Movimientos"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(97, 81)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(265, 23)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(97, 110)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(636, 23)
        Me.txtNombre.TabIndex = 5
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(468, 82)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(265, 23)
        Me.txtNoSocio.TabIndex = 3
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(468, 175)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(265, 22)
        Me.dtpFin.TabIndex = 11
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(97, 175)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(265, 22)
        Me.dtpInicio.TabIndex = 9
        '
        'cbCuentas
        '
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.ItemHeight = 24
        Me.cbCuentas.Location = New System.Drawing.Point(97, 139)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(636, 30)
        Me.cbCuentas.TabIndex = 7
        Me.cbCuentas.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 80)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(368, 80)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "No. Asociado:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 106)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Asociado:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 139)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(56, 20)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Cuenta:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 175)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 20)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Desde:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(368, 172)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(46, 20)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Hasta:"
        '
        'frmMSConsultaMovimientosCuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(758, 537)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.dtpInicio)
        Me.Name = "frmMSConsultaMovimientosCuentas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Movimientos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Public Property TipoCuenta() As Ahorros.clsAhorro.TipoCuenta
    Public Property TipoCuenta() As sifLib.Ahorro.clsAhorros.TipoCuenta
        Get
            Return vTipoCuenta
        End Get
        'Set(ByVal Value As Ahorros.clsAhorro.TipoCuenta)
        Set(ByVal Value As sifLib.Ahorro.clsAhorros.TipoCuenta)
            vTipoCuenta = Value
        End Set
    End Property

    Public Sub Encabezado()

        fg.Cols.Item(1).Caption = "Número de Libreta"
        fg.Cols.Item(2).Caption = "Fecha"
        fg.Cols.Item(3).Caption = "Hora"
        fg.Cols.Item(4).Caption = "Cód. Transacción"
        fg.Cols.Item(5).Caption = "Tipo de Pago"
        fg.Cols.Item(6).Caption = "Valor de Transacción"
        fg.Cols.Item(7).Caption = "Saldo"
        fg.Cols.Item(8).Caption = "Tasa de Interes"
        fg.Cols.Item(9).Caption = "Tipo de Movimiento"
        fg.Cols.Item(10).Caption = "No de Caja"
        fg.Cols.Item(11).Caption = "Usuario de Caja"
        fg.Cols.Item(12).Caption = "Pago de Libreta"
        fg.Cols.Item(13).Caption = "Observacion"
        fg.Cols.Item(14).Caption = "Id de Movimiento"
        fg.Cols.Item(15).Caption = "Año"


        fg.Cols.Item(6).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        fg.Cols.Item(7).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        fg.Cols.Item(8).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom

        fg.Cols.Item(6).Format = "##0.00"
        fg.Cols.Item(7).Format = "##0.00"
        fg.Cols.Item(8).Format = "##0.00"

        fg.Cols.Item(0).Width = 10
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 130
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 100
        fg.Cols.Item(9).Width = 130
        fg.Cols.Item(10).Width = 100
        fg.Cols.Item(11).Width = 100
        fg.Cols.Item(12).Width = 100
        fg.Cols.Item(13).Width = 100
        fg.Cols.Item(14).Width = 100
        fg.Cols.Item(15).Width = 75

    End Sub



    Private Sub frmMSConsultaMovimientosCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Encabezado()
    End Sub
    Protected Sub llenarCuentas()
        Try
            Dim dts As New DataSet
            dts = ahorros.ConsultarCuentaAhorro("NoCuenta", "Dui='" & Me.txtDui.Value & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            cbCuentas.DataSource = dts.Tables(0)
            cbCuentas.DisplayMember = "NoCuenta"
            cbCuentas.ValueMember = "NoCuenta"
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try


    End Sub
    'Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmAGenerico ', Fila As DataRowCollection
    '    Dim sTexto As String ', vCodTipoAhorro As String, pCodPlanAhorro As String, 
    '    Dim vTipoAhorro As String
    '    vTipoAhorro = ""

    '    frm.Text = "Buscar Cuenta"
    '    Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
    '    Try
    '        oAh = New wrAhorro.wsLibAhorro
    '        'If Me.vTipoCuenta = Ahorros.clsAhorro.TipoCuenta.Ahorro Then
    '        If Me.vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Ahorro Then
    '            vTipoAhorro = " and Left(CodTipoAhorro,1)<>'1'"
    '            'ElseIf Me.vTipoCuenta = Ahorros.clsAhorro.TipoCuenta.Aportacion Then
    '        ElseIf Me.vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Aportacion Then
    '            vTipoAhorro = " and Left(CodTipoAhorro,1)='1'"
    '        End If
    '        ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,NoCuentaAnterior,FechaApertura,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,Estado", "Dui='" & Me.txtDui.Value & "'" & vTipoAhorro, "NoCuenta", sUsuario, sPassword, sSucursal)
    '        frm.Datos = ds
    '        frm.C1fgrdResultado.Cols.Item(5).Format = "##0.00"

    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim = "" Then
    '        ElseIf frm.Resultado.Trim <> "" Then
    '            sTexto = frm.Resultado3.Trim
    '            Me.txtNoCuenta.Text = sTexto
    '            '================================================================
    '            Dim inactiva As Boolean
    '            inactiva = ahorros.Temp_Consultar_CtasInactivas(txtNoCuenta.Text)
    '            If inactiva = True Then
    '                Me.lblCtasInactivas.Visible = True
    '                Me.lblEstado.Visible = False
    '            Else
    '                Me.lblCtasInactivas.Visible = False
    '                Me.lblEstado.Visible = True
    '            End If
    '            '================================================================
    '            Select Case frm.Resultado8.Trim
    '                Case "D" 'Digitada
    '                    Me.lblEstado.Text = "DIGITADA"
    '                Case "A" 'A: Activa
    '                    Me.lblEstado.Text = "ACTIVA"
    '                Case "C" 'C: Cancelada
    '                    Me.lblEstado.Text = "CANCELADA"
    '                Case "I" 'Inactiva
    '                    Me.lblEstado.Text = "INACTIVA"
    '                Case "B" 'Bloqueada
    '                    Me.lblEstado.Text = "BLOQUEADA"
    '            End Select
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


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

    Private Sub txtDui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.GotFocus
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
                    Me.txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
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
                    Me.txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                    llenarCuentas()
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim oAh As wrAhorro.wsLibAhorro
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico

        Try

            'If Me.txtNoCuenta.Text = "" = True Then
            '    MsgBox("Debe de ingresar un Número de Cuenta - Módulo Ahorros -", MsgBoxStyle.Information, "Módulo Ahorros")
            'Else
            ds = ahorros.MostrarMovimientos("*", "Fecha", cbCuentas.SelectedValue, "", Me.dtpInicio.Value.ToShortDateString, Me.dtpFin.Value.ToShortDateString, Me.vTipoCuenta, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables("AhMovimientos")
                Encabezado()
           ' End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim ds As New DataSet
        Me.txtDui.Text = ""
        Me.txtDui.Value = ""
        Me.txtNombre.Text = ""
        Me.txtNoSocio.Text = ""
        Me.cbCuentas.DataSource = Nothing
        fg.DataSource = ds
    End Sub

    Private Sub cbCuentas_Validated(sender As Object, e As EventArgs) Handles cbCuentas.Validated
        Dim ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            Dim codTipoAhorro As String
            ds = ahorros.ConsultarCuentaAhorro("CodTipoAhorro", "NoCuenta='" & cbCuentas.SelectedValue & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                codTipoAhorro = dr("CodTipoAhorro")
                If codTipoAhorro.Substring(0, 1).Equals("1") Then
                    vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Aportacion
                Else
                    vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Ahorro
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMSConsultaMovimientosCuentas_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class