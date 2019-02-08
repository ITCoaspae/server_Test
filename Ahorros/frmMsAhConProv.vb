Public Class frmMsAhConProv
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtIntPag As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProv1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New MetroFramework.Controls.MetroButton()
        Me.btnProv1 = New MetroFramework.Controls.MetroButton()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.fg2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIntPag = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 409)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btnLimpiar)
        Me.TabPage2.Controls.Add(Me.btnProv1)
        Me.TabPage2.Controls.Add(Me.txtNoSocio)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtTipoAhorro)
        Me.TabPage2.Controls.Add(Me.fg2)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.dtpR2)
        Me.TabPage2.Controls.Add(Me.dtpR1)
        Me.TabPage2.Controls.Add(Me.txtCodTipoAhorro)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtIntPag)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtMonto)
        Me.TabPage2.Controls.Add(Me.txtSaldo)
        Me.TabPage2.Controls.Add(Me.txtDui)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtAsociado)
        Me.TabPage2.Controls.Add(Me.txtNoCuenta)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(668, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saldos - Consulta de Provisiones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(579, 344)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 28)
        Me.btnLimpiar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnLimpiar.TabIndex = 198
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseSelectable = True
        Me.btnLimpiar.UseStyleColors = True
        '
        'btnProv1
        '
        Me.btnProv1.Location = New System.Drawing.Point(498, 344)
        Me.btnProv1.Name = "btnProv1"
        Me.btnProv1.Size = New System.Drawing.Size(75, 28)
        Me.btnProv1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnProv1.TabIndex = 197
        Me.btnProv1.Text = "Provisiones"
        Me.btnProv1.UseSelectable = True
        Me.btnProv1.UseStyleColors = True
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(327, 16)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(104, 20)
        Me.txtNoSocio.TabIndex = 180
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(241, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "No. Asociado:"
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTipoAhorro.Location = New System.Drawing.Point(185, 69)
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(246, 20)
        Me.txtTipoAhorro.TabIndex = 178
        '
        'fg2
        '
        Me.fg2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fg2.BackColor = System.Drawing.SystemColors.Window
        Me.fg2.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg2.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fg2.BackColorFixed = System.Drawing.Color.Green
        Me.fg2.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fg2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        'Me.fg2.ExplorerBar = CType(((C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExSort Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMove) _
        '    Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.4),C1.Win.C1FlexGrid.Classic.ExplorerBarSettings)
        Me.fg2.ForeColorFixed = System.Drawing.SystemColors.ControlText
        Me.fg2.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fg2.GridColor = System.Drawing.SystemColors.Control
        Me.fg2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg2.Location = New System.Drawing.Point(19, 148)
        Me.fg2.Name = "fg2"
        Me.fg2.NodeClosedPicture = Nothing
        Me.fg2.NodeOpenPicture = Nothing
        Me.fg2.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fg2.OutlineCol = -1
        Me.fg2.Rows = 2
        Me.fg2.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg2.Size = New System.Drawing.Size(635, 190)
        Me.fg2.TabIndex = 8
        Me.fg2.TreeColor = System.Drawing.Color.DarkGray
        Me.fg2.WallPaper = Nothing
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(305, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 16)
        Me.Label21.TabIndex = 175
        Me.Label21.Text = "al"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(16, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 16)
        Me.Label22.TabIndex = 174
        Me.Label22.Text = "Fecha:    Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(327, 122)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(104, 20)
        Me.dtpR2.TabIndex = 4
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(123, 122)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(112, 20)
        Me.dtpR1.TabIndex = 3
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoAhorro.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(123, 69)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoAhorro.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Tipo de Ahorro:"
        '
        'txtIntPag
        '
        Me.txtIntPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntPag.Culture = 17418
        Me.txtIntPag.CustomFormat = "#,##0.00"
        Me.txtIntPag.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtIntPag.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntPag.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntPag.Location = New System.Drawing.Point(507, 95)
        Me.txtIntPag.Name = "txtIntPag"
        Me.txtIntPag.ReadOnly = True
        Me.txtIntPag.ShowDropDownButton = False
        Me.txtIntPag.ShowUpDownButtons = False
        Me.txtIntPag.Size = New System.Drawing.Size(147, 21)
        Me.txtIntPag.TabIndex = 169
        Me.txtIntPag.Tag = Nothing
        Me.txtIntPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntPag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(437, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Saldo Int.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Culture = 17418
        Me.txtMonto.CustomFormat = "#0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMonto.Location = New System.Drawing.Point(123, 95)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        Me.txtMonto.Size = New System.Drawing.Size(112, 21)
        Me.txtMonto.TabIndex = 167
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Culture = 17418
        Me.txtSaldo.CustomFormat = "#0.00"
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldo.Location = New System.Drawing.Point(327, 95)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ShowDropDownButton = False
        Me.txtSaldo.ShowUpDownButtons = False
        Me.txtSaldo.Size = New System.Drawing.Size(104, 21)
        Me.txtSaldo.TabIndex = 166
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(123, 16)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(281, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Saldo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Monto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Nombre Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(123, 42)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(531, 21)
        Me.txtAsociado.TabIndex = 161
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCuenta.Location = New System.Drawing.Point(507, 69)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(147, 20)
        Me.txtNoCuenta.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(437, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "No. Cuenta:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "DUI:"
        '
        'frmMsAhConProv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(724, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhConProv"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Consulta de Provisiones de Interés"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtNoCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.LostFocus

        Try
            Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
            Dim oAsoc As New wrAsociados.wsLibAsoc
            oPrest = New wrAhorro.wsLibAhorro

            If Me.txtNoCuenta.Text.Trim = "" Or Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub

            ds = oPrest.ConsultarCuentaAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
                Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
                ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,ApellidoCas,Nombres", "Dui='" & Me.txtDui.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Cat_Asociados").Rows(0)
                Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombres")), "", dr("Nombres")) & " " & IIf(IsDBNull(dr("Apellido1")), "", dr("Apellido1")) & " " & IIf(IsDBNull(dr("Apellido2")), "", dr("Apellido2"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
                Dim oAsoc As New wrAsociados.wsLibAsoc
                oPrest = New wrAhorro.wsLibAhorro

                If Me.txtNoCuenta.Text.Trim = "" Or Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub

                ds = oPrest.ConsultarCuentaAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                    Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                    Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                    Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
                    Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
                    ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,ApellidoCas,Nombres", "Dui='" & Me.txtDui.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
                    dr = ds.Tables(0).Rows(0)
                    Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombres")), "", dr("Nombres")) & " " & IIf(IsDBNull(dr("Apellido1")), "", dr("Apellido1")) & " " & IIf(IsDBNull(dr("Apellido2")), "", dr("Apellido2"))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub frmMsAhConProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNoCuenta.Focus()
    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick

        Dim ofrm As New frmAGenerico
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)<>'1'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            If ofrm.Resultado.Trim = "" Then Exit Sub
            txtTipoAhorro.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

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
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Cuenta"
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,Saldo_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and Left(CodTipoAhorro,1)<>'1' and CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then

                sTexto = frm.Resultado3.Trim
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,Saldo_CuentaAhorro,SaldoInteresPendiente,Monto", "NoCuenta='" & sTexto.Trim & "' and CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables("AhCuentasAhorro").Rows(0)
                    Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                    Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                    Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                    Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_CuentaAhorro")), 0, dr("Saldo_CuentaAhorro"))
                    Me.txtIntPag.Value = IIf(IsDBNull(dr("SaldoInteresPendiente")), 0, dr("SaldoInteresPendiente"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
                        Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                        Me.txtCodTipoAhorro.Focus()
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtCodTipoAhorro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.LostFocus

        If Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow
            ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and left(CodTipoAhorro,1)<>'1'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                txtCodTipoAhorro.Text = dr("CodTipoAhorro")
                txtTipoAhorro.Text = dr("Descripcion")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnProv1_Click(sender As Object, e As EventArgs) Handles btnProv1.Click
        Dim oPrest As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
        Try
            oPrest = New wrAhorro.wsLibAhorro
            ds = oPrest.ConsultarProvisiones("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Fecha>='" & Me.dtpR1.Value.Date & "' and Fecha<='" & Me.dtpR2.Value.Date & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            fg2.DataSource = ds.Tables("AhProvisiones")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            Dim ds As New DataSet
            Me.txtDui.Text = ""
            Me.txtDui.Value = ""
            Me.txtAsociado.Text = ""
            Me.txtNoSocio.Text = ""
            Me.txtNoCuenta.Text = ""
            Me.txtCodTipoAhorro.Text = ""
            Me.txtTipoAhorro.Text = ""
            Me.txtMonto.Value = 0
            Me.txtSaldo.Value = 0
            Me.txtIntPag.Value = 0
            fg2.DataSource = ds
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class