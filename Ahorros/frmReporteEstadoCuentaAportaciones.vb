Public Class frmReporteEstadoCuentaAportaciones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Private vTipo As String, vCodTipoAhorro As String, pVar As Boolean
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCuentas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cbCuentas = New MetroFramework.Controls.MetroComboBox()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(92, 88)
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(413, 20)
        Me.txtAsociado.TabIndex = 3
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(90, 63)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(138, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(367, 114)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(138, 20)
        Me.dtpFechaFin.TabIndex = 7
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(92, 114)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(139, 20)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(422, 169)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(83, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 12
        Me.MetroButton1.Text = "Reporte"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "DUI"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 88)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Nombre:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 114)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Desde:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(326, 114)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Hasta"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 138)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "No. Cuenta:"
        '
        'cbCuentas
        '
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.ItemHeight = 23
        Me.cbCuentas.Location = New System.Drawing.Point(92, 138)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(413, 29)
        Me.cbCuentas.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCuentas.TabIndex = 11
        Me.cbCuentas.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbCuentas.UseCustomBackColor = True
        Me.cbCuentas.UseCustomForeColor = True
        Me.cbCuentas.UseSelectable = True
        Me.cbCuentas.UseStyleColors = True
        '
        'frmReporteEstadoCuentaAportaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(631, 288)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteEstadoCuentaAportaciones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Estado de Cuenta de Aportación"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal Value As String)
            vTipo = Value
        End Set
    End Property

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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        If (e.KeyChar = Convert.ToChar(Keys.Enter) Or e.KeyChar = Convert.ToChar(Keys.Return)) Then SendKeys.Send("{TAB}")
        ' If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim sTexto As String
        '--------------------CAMBIO APLICADO 31/08/2019  PROG01 ----------------------------
        '--------------------SOLICITADO POR GERENCIA PARA CLASIFICAR CLIENTES VIP-----------
        Try
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros
            ElseIf sTexto <> "" Then

                Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
                ds = oAsoc.ConsultarAsociadoVIP("DUI,Nombre", "DUI='" & sTexto & "'", "DUI,Nombre", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Dim ofrmAut As New frmMsAutorizacion
                    ofrmAut.TipoPermiso = "P"
                    ofrmAut.NumPrograma = "VIP001"
                    ofrmAut.ShowDialog()
                    If ofrmAut.Autoriza = True Then
                        '=========================================================================================
                        Dim oAsoc1 As New wrAsociados.wsLibAsoc, ds1 As New Data.DataSet, dr1 As DataRow
                        ds1 = oAsoc1.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                        If ds1.Tables(0).Rows.Count > 0 Then
                            dr1 = ds1.Tables(0).Rows(0)
                            Me.txtDui.Value = Trim(dr("DUI"))
                            Me.txtAsociado.Text = Trim(dr1("Nombres")) & ", " & dr1("Apellido1") & " " & dr1("Apellido2") & " " & dr1("ApellidoCas")
                            llenarCuentas()
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Seleccionar Usuario que autoriza la consulta del Cliente VIP.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    Dim oAsoc2 As New wrAsociados.wsLibAsoc, ds2 As New Data.DataSet, dr2 As DataRow
                    ds2 = oAsoc2.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    If ds2.Tables(0).Rows.Count > 0 Then
                        dr2 = ds2.Tables(0).Rows(0)
                        Me.txtDui.Value = Trim(dr2("DUI"))
                        Me.txtAsociado.Text = Trim(dr2("Nombres")) & ", " & dr2("Apellido1") & " " & dr2("Apellido2") & " " & dr2("ApellidoCas")
                        llenarCuentas()
                    End If
                End If

            End If
            '-------------- FIN DEL CAMBIO DE CLIENTE VIP
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim ds As New Data.DataSet
        Try
            Dim dtsAhorro As New DataSet
            dtsAhorro = ahorro.ConsultarCuentaAhorro("codTipoAhorro", " Nocuenta = '" & cbCuentas.SelectedValue & "'", "Nocuenta", sUsuario, sPassword, sSucursal)

            vCodTipoAhorro = dtsAhorro.Tables(0).Rows(0).Item(0)
            ds = ahorro.ReporteEstadoCuentaAportaciones("'" & Trim(Me.txtDui.Text) & "'", "'" & cbCuentas.SelectedValue & "'", vCodTipoAhorro, Me.dtpFechaInicio.Value.ToLongDateString, Me.dtpFechaFin.Value.ToLongDateString, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 60, 0)
            ofrm.ShowDialog()
            pVar = False
            ' Me.chkDPF.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmReporteEstadoCuentaAhorroAportaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pVar = False
    End Sub
    Protected Sub llenarCuentas()
        Dim dts As New DataSet
        dts = ahorro.ConsultarCuentaAportacion("NoCuenta,codTipoAhorro ", "Dui='" & Me.txtDui.Value & "' ", "NoCuenta", sUsuario, sPassword, sSucursal)
        cbCuentas.DataSource = dts.Tables(0)
        cbCuentas.DisplayMember = "NoCuenta"
        cbCuentas.ValueMember = "NoCuenta"

    End Sub

    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged

    End Sub

    Private Sub cbTipoAhorro_Validated(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmReporteEstadoCuentaAhorroAportaciones_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class