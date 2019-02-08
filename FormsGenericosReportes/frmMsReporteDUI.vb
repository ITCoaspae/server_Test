Public Class frmMsReporteDUI
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vTitulo As String, vNumReporte As String, dsRep As New DataSet, vMonto As Double, vMontoGarantia As Double, vNumPagos As Double, pVar As Boolean
    Friend WithEvents lblNoCuenta As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nCargos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents c1nAbonos As C1.Win.C1Input.C1NumericEdit

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
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDPF As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDPF = New System.Windows.Forms.CheckBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoCuenta = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1nCargos = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nAbonos = New C1.Win.C1Input.C1NumericEdit()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDPF
        '
        Me.chkDPF.Location = New System.Drawing.Point(432, 8)
        Me.chkDPF.Name = "chkDPF"
        Me.chkDPF.Size = New System.Drawing.Size(104, 16)
        Me.chkDPF.TabIndex = 176
        Me.chkDPF.Text = "Visualizar &DPF"
        Me.chkDPF.Visible = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(16, 32)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(256, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Nombres Asociado:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(152, 32)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(88, 20)
        Me.txtNoSocio.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(152, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "No. Asociado:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "DUI Asociado:"
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.Location = New System.Drawing.Point(16, 64)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(76, 16)
        Me.lblNoCuenta.TabIndex = 173
        Me.lblNoCuenta.Text = "No Cuenta:"
        Me.lblNoCuenta.Visible = False
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Location = New System.Drawing.Point(96, 64)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(173, 20)
        Me.txtNoCuenta.TabIndex = 1
        Me.txtNoCuenta.Visible = False
        '
        'lblA
        '
        Me.lblA.Location = New System.Drawing.Point(16, 64)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(76, 16)
        Me.lblA.TabIndex = 174
        Me.lblA.Text = "Otros Abonos:"
        Me.lblA.Visible = False
        '
        'lblC
        '
        Me.lblC.Location = New System.Drawing.Point(240, 64)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(76, 16)
        Me.lblC.TabIndex = 175
        Me.lblC.Text = "Otros Cargos:"
        Me.lblC.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkDPF)
        Me.GroupBox1.Controls.Add(Me.c1nCargos)
        Me.GroupBox1.Controls.Add(Me.c1nAbonos)
        Me.GroupBox1.Controls.Add(Me.lblC)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox1.Controls.Add(Me.lblNoCuenta)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'c1nCargos
        '
        Me.c1nCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCargos.CustomFormat = "###,###,##0.00"
        Me.c1nCargos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCargos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCargos.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nCargos.Location = New System.Drawing.Point(328, 64)
        Me.c1nCargos.Name = "c1nCargos"
        Me.c1nCargos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCargos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCargos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCargos.ShowDropDownButton = False
        Me.c1nCargos.ShowUpDownButtons = False
        Me.c1nCargos.Size = New System.Drawing.Size(96, 21)
        Me.c1nCargos.TabIndex = 3
        Me.c1nCargos.Tag = Nothing
        Me.c1nCargos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nAbonos
        '
        Me.c1nAbonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAbonos.CustomFormat = "###,###,##0.00"
        Me.c1nAbonos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAbonos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAbonos.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nAbonos.Location = New System.Drawing.Point(96, 64)
        Me.c1nAbonos.Name = "c1nAbonos"
        Me.c1nAbonos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAbonos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAbonos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAbonos.ShowDropDownButton = False
        Me.c1nAbonos.ShowUpDownButtons = False
        Me.c1nAbonos.Size = New System.Drawing.Size(96, 21)
        Me.c1nAbonos.TabIndex = 2
        Me.c1nAbonos.Tag = Nothing
        Me.c1nAbonos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(492, 130)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1022
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsReporteDUI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(621, 171)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteDUI"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAbonos, System.ComponentModel.ISupportInitialize).EndInit()
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

    Public Property dRep() As DataSet
        Get
            Return dsRep
        End Get
        Set(ByVal Value As DataSet)
            dsRep = Value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return vMonto
        End Get
        Set(ByVal Value As Double)
            vMonto = Value
        End Set
    End Property

    Public Property MontoGarantia() As Double
        Get
            Return vMontoGarantia
        End Get
        Set(ByVal Value As Double)
            vMontoGarantia = Value
        End Set
    End Property

    Public Property NumPagos() As Double
        Get
            Return vNumPagos
        End Get
        Set(ByVal Value As Double)
            vNumPagos = Value
        End Set
    End Property

#End Region

    Private Sub frmMsReporteDUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Titulo
        pVar = False
        Select Case vNumReporte
            Case 0 'Cuentas de Asociado
                txtNoCuenta.Visible = False
                lblNoCuenta.Visible = False
                'Size = New Size(621; 171)
                'GroupBox1.Size = New Size(544, 64)
                'btnProcesar1.Location = New Point(144, 72)
                'btnCerrar.Location = New Point(328, 72)
                Me.chkDPF.Visible = True
            Case 1 'Impresión de Certificado de Depósito
                txtNoCuenta.Visible = True
                lblNoCuenta.Visible = True
                Me.c1nAbonos.Visible = False
                Me.c1nCargos.Visible = False
                Me.Size = New Size(568, 168)
                GroupBox1.Size = New Size(544, 96)
                btnProcesar1.Location = New Point(112, 104)
                '1 btnCerrar.Location = New Point(336, 104)
                Me.chkDPF.Visible = False
            Case 5 'Liquidación de Asociado Retirado
                txtNoCuenta.Visible = False
                lblNoCuenta.Visible = False
                Me.lblA.Visible = True
                Me.lblC.Visible = True
                Me.c1nAbonos.Visible = True
                Me.c1nCargos.Visible = True
                Me.Size = New Size(568, 168)
                GroupBox1.Size = New Size(544, 96)
                btnProcesar1.Location = New Point(112, 104)
                ' btnCerrar.Location = New Point(336, 104)
                Me.chkDPF.Visible = False
        End Select
    End Sub



    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim oAsoc As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico

        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,NoSocio", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Mostrar Asociados"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Dim sDui As String, sNombre As String
                sDui = ofrm.Resultado.Trim
                sNombre = ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim & " " & ofrm.Resultado4.Trim

                Me.txtDui.Value = sDui.Trim
                Me.txtNombre.Text = sNombre
                Me.txtNoSocio.Text = ofrm.Resultado5.Trim
            End If
        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Dim ds As New DataSet
            Select Case vNumReporte
                Case "0" 'REPORTE CUENTAS ASOCIADOS
                    Dim frmVi As New frmVisorRS
                    OpcionRS = 71
                    frmVi.dui = Me.txtDui.Text.Trim
                    frmVi.todasCtas = Me.chkDPF.Checked
                    frmVi.ShowDialog()
                'Dim oAsoc As New wrAsociados.wsLibAsoc
                'ds = oAsoc.ReporteCuentasAsociado(Me.txtDui.Text, Me.chkDPF.Checked, sUsuario, sPassword, sSucursal)
                'Dim ofrm As New frmVisor(ds, 65, 0)
                'ofrm.ShowDialog()
                'pVar = False
                'Me.chkDPF.Checked = False
                Case "1" 'Impresión de Certificado de Depósito
                    Dim oAhorro As New wrAhorro.wsLibAhorro
                    ds = oAhorro.ExportacionDatos_DPF(False, True, Me.txtNoCuenta.Text.Trim, Now, Now, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 89, 0)
                    ofrm.ShowDialog()
                Case "2" 'Partida de Renuncia de Asociados
                    Dim oCtb As New wrConta.wsLibContab, vCodPartida As String
                    vCodPartida = "AS0002"
                    If oCtb.GenerarPartidaRenunciaAsociado(vCodPartida, Now, Me.txtNoSocio.Text.Trim, sUsuario, sPassword, sSucursal) = True Then
                        MessageBox.Show("Partida generada con éxito.", vTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                Case "3" 'CÁLCULO DE CUOTA PARA PRÉSTAMOS
                    Dim oPrest As New wrPrestamo.wsLibPrest
                    ds = oPrest.DetalleCuota(Me.txtDui.Text, Me.txtNoSocio.Text.Trim, Me.txtNombre.Text.Trim, vMonto, vNumPagos, vMontoGarantia, dsRep, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 92, 0)
                    ofrm.ShowDialog()
                Case "5" 'Liquidación de Asociado Retirado
                    Dim oItem As New wrAsociados.wsLibAsoc
                    ds = oItem.LiquidacionAsociado(Me.txtDui.Text, Now.ToShortDateString, Me.c1nAbonos.Value, Me.c1nCargos.Value, Now.ToShortDateString, False, False, Now, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 139, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
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

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim oAsoc As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count = 1 Then

                Me.txtNombre.Text = ""
                dr = ds.Tables(0).Rows(0)
                Me.txtNombre.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
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
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico
        frm.Text = "Buscar Cuenta"
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarCuentaAhorro("CodTipoAhorro,NoCuenta,FechaInicioApertura as Apertura,Plazo,MontoApertura as Monto,SaldoDisponible_CuentaAhorro as Saldo", "Dui='" & Me.txtDui.Value & "' and Left(CodTipoAhorro,1)='6'", "NoCuenta", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                Me.txtNoCuenta.Text = frm.Resultado2.Trim
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkDPF_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDPF.CheckedChanged
        If Me.chkDPF.Checked = True And pVar = False Then
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHN011"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                pVar = True
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                Me.chkDPF.Checked = False
                ofrmAut.Dispose()
            End If
        End If
    End Sub

    'Private Sub chkDPF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDPF.LostFocus

    'End Sub

End Class