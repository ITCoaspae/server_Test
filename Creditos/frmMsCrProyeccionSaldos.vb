Imports Microsoft.Reporting.WinForms
Public Class frmMsCrProyeccionSaldos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnLimpiar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel2 As Panel
    Private WithEvents rsVISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Private dsPr As New DataSet
    Dim asociados As New wrAsociados.wsLibAsoc

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaOtorg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecVenc As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDiaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpFecConsulta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoPago As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtUltimoPago = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpFecConsulta = New System.Windows.Forms.DateTimePicker()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtDiaPago = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFecVenc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFechaOtorg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLimpiar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rsVISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblCategoria)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtUltimoPago)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.dtpFecConsulta)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.txtDiaPago)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtFecVenc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoCredito)
        Me.GroupBox1.Controls.Add(Me.txtTipoCredito)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFechaOtorg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblCategoria
        '
        Me.lblCategoria.BackColor = System.Drawing.Color.White
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(418, 14)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 16)
        Me.lblCategoria.TabIndex = 212
        Me.lblCategoria.Text = "Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(418, 133)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 16)
        Me.Label24.TabIndex = 193
        Me.Label24.Text = "Fec. Consulta:"
        '
        'txtUltimoPago
        '
        Me.txtUltimoPago.BackColor = System.Drawing.Color.White
        Me.txtUltimoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimoPago.Location = New System.Drawing.Point(300, 131)
        Me.txtUltimoPago.MaxLength = 8
        Me.txtUltimoPago.Name = "txtUltimoPago"
        Me.txtUltimoPago.ReadOnly = True
        Me.txtUltimoPago.Size = New System.Drawing.Size(112, 20)
        Me.txtUltimoPago.TabIndex = 209
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(212, 131)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 16)
        Me.Label25.TabIndex = 208
        Me.Label25.Text = "Último pago:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecConsulta
        '
        Me.dtpFecConsulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecConsulta.Location = New System.Drawing.Point(506, 131)
        Me.dtpFecConsulta.Name = "dtpFecConsulta"
        Me.dtpFecConsulta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFecConsulta.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstado.Location = New System.Drawing.Point(506, 12)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(114, 21)
        Me.lblEstado.TabIndex = 192
        '
        'txtDiaPago
        '
        Me.txtDiaPago.BackColor = System.Drawing.Color.White
        Me.txtDiaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaPago.Location = New System.Drawing.Point(94, 131)
        Me.txtDiaPago.MaxLength = 8
        Me.txtDiaPago.Name = "txtDiaPago"
        Me.txtDiaPago.ReadOnly = True
        Me.txtDiaPago.Size = New System.Drawing.Size(112, 20)
        Me.txtDiaPago.TabIndex = 191
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(8, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 190
        Me.Label21.Text = "Día de pago:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecVenc
        '
        Me.txtFecVenc.BackColor = System.Drawing.Color.White
        Me.txtFecVenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecVenc.Location = New System.Drawing.Point(300, 97)
        Me.txtFecVenc.MaxLength = 8
        Me.txtFecVenc.Name = "txtFecVenc"
        Me.txtFecVenc.ReadOnly = True
        Me.txtFecVenc.Size = New System.Drawing.Size(112, 20)
        Me.txtFecVenc.TabIndex = 189
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(212, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "Vencimiento:"
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(300, 65)
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.ReadOnly = True
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoCredito.TabIndex = 187
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTipoCredito.Location = New System.Drawing.Point(362, 64)
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(258, 21)
        Me.txtTipoCredito.TabIndex = 186
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(212, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 21)
        Me.Label20.TabIndex = 185
        Me.Label20.Text = "Tipo de Crédito:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(300, 12)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(112, 20)
        Me.txtNoSocio.TabIndex = 182
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(212, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "No. Asociado:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Culture = 17418
        Me.txtSaldo.CustomFormat = "#0.00"
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldo.Location = New System.Drawing.Point(506, 97)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(114, 19)
        Me.txtSaldo.TabIndex = 142
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(94, 12)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 18)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(418, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Saldo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaOtorg
        '
        Me.txtFechaOtorg.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaOtorg.Location = New System.Drawing.Point(94, 97)
        Me.txtFechaOtorg.MaxLength = 8
        Me.txtFechaOtorg.Name = "txtFechaOtorg"
        Me.txtFechaOtorg.ReadOnly = True
        Me.txtFechaOtorg.Size = New System.Drawing.Size(112, 20)
        Me.txtFechaOtorg.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 29)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Fec. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Otorgamiento:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(94, 38)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(526, 21)
        Me.txtAsociado.TabIndex = 20
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(94, 65)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPrestamo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Préstamo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "DUI:"
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Location = New System.Drawing.Point(162, 225)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(75, 28)
        Me.btnLimpiar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiar1.TabIndex = 218
        Me.btnLimpiar1.Text = "Limpiar"
        Me.btnLimpiar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLimpiar1.UseSelectable = True
        Me.btnLimpiar1.UseStyleColors = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rsVISOR)
        Me.Panel2.Location = New System.Drawing.Point(23, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 229)
        Me.Panel2.TabIndex = 219
        '
        'rsVISOR
        '
        Me.rsVISOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rsVISOR.Location = New System.Drawing.Point(0, 0)
        Me.rsVISOR.Name = "rsVISOR"
        Me.rsVISOR.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rsVISOR.ServerReport.ReportPath = "/RS_SIF_ERP/"
        Me.rsVISOR.ServerReport.ReportServerUrl = New System.Uri("http://jaem90/ReportServer", System.UriKind.Absolute)
        Me.rsVISOR.Size = New System.Drawing.Size(631, 227)
        Me.rsVISOR.TabIndex = 1
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 225)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(133, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 220
        Me.MetroButton1.Text = "Generar Proyección"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsCrProyeccionSaldos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(679, 525)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnLimpiar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(679, 525)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(679, 525)
        Me.Name = "frmMsCrProyeccionSaldos"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Proyección de Saldos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.ConsultarPRPrestamosTipoCredito("a.CodPrestamo,a.CodAnteriorPrestamo,a.CodTipoCredito,b.Descripcion as Tipo_Credito,a.Monto,a.Saldo_Capital as Saldo,a.FechaOtorgamiento as Fecha_Apertura,a.FechaVencimiento", "a.Dui='" & Me.txtDui.Value & "'", "a.FechaOtorgamiento", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                txtCodPrestamo.Text = sTexto.Trim
                Me.txtCodTipoCredito.Text = frm.Resultado3.Trim
                Me.txtTipoCredito.Text = frm.Resultado4.Trim
                txtCodPrestamo_LostFocus(sender, e)
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
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
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
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
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.LostFocus
        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, pTotal As Decimal
        Dim oCaja As New wrCaja.wsLibCaja, dsCB As New DataSet

        Try
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then
            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                        Me.txtDiaPago.Text = dr("FechaPrimeraCuota")
                    End If
                    If Not IsDBNull(dr("FechaUltimoPago")) Then
                        Me.txtUltimoPago.Text = dr("FechaUltimoPago")
                    End If
                    'D: Digitado (sin tabla de amortización); A: Activo (ya se ha generado tabla de amortización); C: Cancelado
                    Select Case Trim(IIf(IsDBNull(dr("Estado")), "D", dr("Estado")))
                        Case "D"
                            Me.lblEstado.Text = "Estado: Digitado" & vbCrLf & "Categoría: " & IIf(IsDBNull(dr("Categoria")), "", dr("Categoria"))
                        Case "A"
                            Me.lblEstado.Text = "Estado: Activo" & vbCrLf & "Categoría: " & IIf(IsDBNull(dr("Categoria")), "", dr("Categoria"))
                        Case "C"
                            Me.lblEstado.Text = "Estado: Cancelado" & vbCrLf & "Categoría: " & IIf(IsDBNull(dr("Categoria")), "", dr("Categoria"))
                    End Select
                    Me.txtFechaOtorg.Text = IIf(IsDBNull(dr("FechaOtorgamiento")), Now, dr("FechaOtorgamiento"))
                    Me.txtFecVenc.Text = IIf(IsDBNull(dr("FechaVencimiento")), Now, dr("FechaVencimiento"))
                    Me.txtCodTipoCredito.Text = IIf(IsDBNull(dr("CodTipoCredito")), "", dr("CodTipoCredito"))
                    Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital"))

                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmMsCrProyeccionSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecConsulta.Value = Now
    End Sub

    Private Sub Limpiar()
        Me.txtDui.Text = ""
        Me.txtDui.Value = ""
        Me.txtAsociado.Text = ""
        Me.txtNoSocio.Text = ""
        Me.txtCodPrestamo.Text = ""
        Me.txtCodTipoCredito.Text = ""
        Me.txtTipoCredito.Text = ""
        Me.txtFechaOtorg.Text = ""
        Me.txtFecVenc.Text = ""
        Me.txtSaldo.Value = 0
        Me.txtDiaPago.Text = ""
        Me.dtpFecConsulta.Value = Now

        '  Me.btnEstadoCuenta1.Enabled = False
    End Sub





    Private Sub btImpProy1_Click(sender As Object, e As EventArgs)
        Try
            If dsPr.Tables(0).Rows.Count > 0 Then
                Dim ofrm As New frmVisor(dsPr, 122, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEstadoCuenta1_Click(sender As Object, e As EventArgs)
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
            ds = oPrest.EstadoCuentaProyeccion(Me.txtCodPrestamo.Text.Trim, Me.txtDui.Value, dsPr, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 113, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        Try
            Limpiar()
            Me.rsVISOR.Clear()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim dtsConfiguracionRs As New DataSet
        dtsConfiguracionRs = asociados.ConsultarParametros("rutaRs,urlRs,usuarioRs,contraseniaRs", "", " rutaRs", sUsuario, sPassword, sSucursal)
        If dtsConfiguracionRs.Tables(0).Rows.Count > 0 Then

            Dim RUTA As String
            Dim userRPT As String
            Dim pwdRPT As String
            Dim carpetaRs As String
            carpetaRs = My.Settings.CarpetaRS
            RUTA = "/" & carpetaRs & "/rsProyeccionPrestamos"
            Me.rsVISOR.ServerReport.ReportPath = dtsConfiguracionRs.Tables(0).Rows(0).Item("rutaRs")
            Me.rsVISOR.ServerReport.ReportServerUrl = New Uri(dtsConfiguracionRs.Tables(0).Rows(0).Item("urlRs"))
            userRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("usuarioRs")  'My.Settings.UserRS
            pwdRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("contraseniaRs") 'My.Settings.PwdRS

            Me.rsVISOR.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(userRPT, pwdRPT)
            Me.rsVISOR.ServerReport.ReportPath = RUTA


            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "codPrestamo"
            parametro.Values.Add(txtCodPrestamo.Text.Trim)

            Dim fechaProyeccion As ReportParameter = New ReportParameter
            fechaProyeccion.Name = "fechaProyeccion"
            fechaProyeccion.Values.Add(dtpFecConsulta.Value.ToShortDateString)

            parametro.Visible = False
            fechaProyeccion.Visible = False
            Dim arrayParametros(1) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = fechaProyeccion
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()

        End If
    End Sub
End Class