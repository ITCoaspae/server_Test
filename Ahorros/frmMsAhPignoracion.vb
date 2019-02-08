Public Class frmMsAhPignoracion
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoPignorado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fgPignorada As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhPignoracion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecVenc = New System.Windows.Forms.DateTimePicker()
        Me.c1nMontoPignorado = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fgPignorada = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nMontoPignorado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgPignorada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecVenc)
        Me.GroupBox1.Controls.Add(Me.c1nMontoPignorado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(92, 11)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(8, 20)
        Me.txtCodTipoAhorro.TabIndex = 159
        Me.txtCodTipoAhorro.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Fec. Vencimiento:"
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecVenc.Location = New System.Drawing.Point(130, 42)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(180, 20)
        Me.dtpFecVenc.TabIndex = 1
        '
        'c1nMontoPignorado
        '
        Me.c1nMontoPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoPignorado.CustomFormat = "###,###,##0.00"
        Me.c1nMontoPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoPignorado.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoPignorado.Location = New System.Drawing.Point(418, 39)
        Me.c1nMontoPignorado.Name = "c1nMontoPignorado"
        Me.c1nMontoPignorado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoPignorado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoPignorado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoPignorado.ShowDropDownButton = False
        Me.c1nMontoPignorado.ShowUpDownButtons = False
        Me.c1nMontoPignorado.Size = New System.Drawing.Size(180, 21)
        Me.c1nMontoPignorado.TabIndex = 2
        Me.c1nMontoPignorado.Tag = Nothing
        Me.c1nMontoPignorado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(316, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Monto Pignorado:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCuenta.Location = New System.Drawing.Point(418, 12)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(180, 20)
        Me.txtNoCuenta.TabIndex = 147
        Me.txtNoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(316, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 16)
        Me.Label28.TabIndex = 148
        Me.Label28.Text = "No. Cuenta:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(130, 16)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(180, 20)
        Me.txtCodPrestamo.TabIndex = 0
        Me.txtCodPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Cod.Préstamo:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 260)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.Size = New System.Drawing.Size(613, 90)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 2
        Me.ttip.SetToolTip(Me.fg, "Doble click para seleccionar una cuenta a pignorar")
        '
        'fgPignorada
        '
        Me.fgPignorada.AllowEditing = False
        Me.fgPignorada.BackColor = System.Drawing.Color.White
        Me.fgPignorada.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPignorada.Location = New System.Drawing.Point(23, 372)
        Me.fgPignorada.Name = "fgPignorada"
        Me.fgPignorada.Rows.Count = 1
        Me.fgPignorada.Size = New System.Drawing.Size(613, 90)
        Me.fgPignorada.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgPignorada.Styles"))
        Me.fgPignorada.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(20, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Cuentas Pignoradas:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(20, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Listado de Cuentas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtAsociado)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(613, 75)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(130, 16)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(88, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "DUI Asociado:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(518, 16)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(80, 20)
        Me.txtNoSocio.TabIndex = 162
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(432, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "No. Asociado:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 24)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Nombre del Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(130, 42)
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(468, 24)
        Me.txtAsociado.TabIndex = 1
        '
        'lblMax
        '
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.Color.Green
        Me.lblMax.Location = New System.Drawing.Point(408, 225)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMax.Size = New System.Drawing.Size(216, 16)
        Me.lblMax.TabIndex = 154
        Me.lblMax.Text = "Porcentaje a pignorar: $0.00"
        '
        'lblMonto
        '
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Green
        Me.lblMonto.Location = New System.Drawing.Point(29, 225)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(304, 16)
        Me.lblMonto.TabIndex = 152
        Me.lblMonto.Text = "Monto máximo de cobertura: $0.00"
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton3.Location = New System.Drawing.Point(399, 468)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 172
        Me.MetroButton3.Text = "Pignorar"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(480, 468)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 173
        Me.MetroButton1.Text = "Despignorar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.Location = New System.Drawing.Point(561, 468)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 174
        Me.MetroButton2.Text = "Borrar"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMsAhPignoracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(650, 512)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fgPignorada)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 512)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 512)
        Me.Name = "frmMsAhPignoracion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Pignoración de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nMontoPignorado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgPignorada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private pSaldo As Double, pDisponible As Double, pFecVenc As Date, pMaximo As Double, vSumPignoradoxCuenta As Double

#Region "Propiedades"

    Public Property Saldo() As Double
        Get
            Return pSaldo
        End Get
        Set(ByVal Value As Double)
            pSaldo = Value
        End Set
    End Property

    Public Property Disponible() As Double
        Get
            Return pDisponible
        End Get
        Set(ByVal Value As Double)
            pDisponible = Value
        End Set
    End Property

#End Region

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                Me.dtpFecVenc.Value = IIf(IsDBNull(dr("FechaVencimiento")), Now, dr("FechaVencimiento"))
                pFecVenc = Me.dtpFecVenc.Value
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodPrestamo.Validating
        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                Me.dtpFecVenc.Value = IIf(IsDBNull(dr("FechaVencimiento")), Now, dr("FechaVencimiento"))
                pFecVenc = Me.dtpFecVenc.Value
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: NO EXISTE EL CODIGO DE PRESTAMO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick

        Try
            If Me.fg.Row <> -1 Then

                Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow, vSumPign As Double, vPorPigPar As Double

                If Me.txtCodPrestamo.Text.Trim = "" Then
                    MsgBox("Ingrese el Código de Préstamo.", MsgBoxStyle.Critical, "Validación del Sistema")
                    Exit Sub
                End If

                Me.txtNoCuenta.Text = Me.fg.Item(Me.fg.Row, "NoCuenta")
                Me.txtCodTipoAhorro.Text = Me.fg.Item(Me.fg.Row, "CodTipoAhorro")
                ds = oAhorro.ConsultarParametros("PorcentajePignoracion", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    vPorPigPar = dr("PorcentajePignoracion") / 100
                Else
                    vPorPigPar = 0
                End If
                ds.Clear()
                ds = oAhorro.ConsultarCuentaPignorada("*", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Estado='N'", "NoCuenta", sUsuario, sPassword, sSucursal)
                For Each dr In ds.Tables("AhPignoraciones").Rows
                    vSumPign = vSumPign + dr("PorcentajePignora")
                Next
                vSumPign = vPorPigPar - (vSumPign / 100)
                vSumPignoradoxCuenta = vSumPign

                Saldo = IIf(Me.fg.Item(Me.fg.Row, "Saldo") Is DBNull.Value, 0, Me.fg.Item(Me.fg.Row, "Saldo"))
                Saldo = Math.Round(Saldo, 2)
                pMaximo = Saldo * vSumPign
                Me.c1nMontoPignorado.Value = Math.Round(pMaximo, 2)
                Me.lblMax.Text = "Porcentaje a pignorar: " & CStr(Math.Round((Me.c1nMontoPignorado.Value / (Saldo * vSumPign)) * 100, 2)) & "%"
                Me.lblMonto.Text = "Monto máximo de cobertura: $" & CStr(Math.Round(Saldo * vSumPign, 2))

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMsAhPignoracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecVenc.Value = Now
    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(0).Width = 85 'No. Cuenta
        fg.Cols.Item(1).Width = 70 'Saldo
        fg.Cols.Item(2).Width = 110 'Disponible Cuenta
        fg.Cols.Item(3).Width = 65 'Pignorada
        fg.Cols.Item(4).Width = 65 'Monto Pignorado
        fg.Cols.Item(5).Width = 80 '% Pignoración
        fg.Cols.Item(6).Width = 100 'Tipo de Ahorro
        fg.Cols.Item(7).Width = 135 'Porcentaje disponible a pignorar

        fg.Cols.Item(5).Caption = "% Pignorado"
        fg.Cols.Item(7).Caption = "%Disponible_a_Pignorar"

        Me.fg.Cols.Item(1).Format = "##0.00"
        Me.fg.Cols.Item(2).Format = "##0.00"
        Me.fg.Cols.Item(4).Format = "##0.00"
        Me.fg.Cols.Item(5).Format = "##0.00"
        Me.fg.Cols.Item(7).Format = "##0.00"

    End Sub

    Private Sub EncabezadoPignoradas()

        Me.fgPignorada.Cols.Item(0).Width = 0
        Me.fgPignorada.Cols.Item(7).Width = 0

        Me.fgPignorada.Cols.Item(1).Format = "##0.00"
        Me.fgPignorada.Cols.Item(2).Format = "##0.00"
        Me.fgPignorada.Cols.Item(3).Format = "##0.00"
        Me.fgPignorada.Cols.Item(4).Format = "##0.00"

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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
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
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Dim sTexto As String
            If Me.txtDui.Value Is DBNull.Value Then Exit Sub

            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
            Dim oAh As New wrAhorro.wsLibAhorro
            Try
                oAsoc = New wrAsociados.wsLibAsoc
                sTexto = Me.txtDui.Value
                If sTexto = "" Then      'Filtrar Registros

                ElseIf sTexto <> "" Then

                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtDui.Value = Trim(dr("DUI"))
                        Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                        Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                        ds = oAh.ConsultarCuentaAhorro("NoCuenta,Saldo_CuentaAhorro as Saldo,SaldoDisponible_CuentaAhorro as Disponible_Cuenta,Pignorado as Pignorada,MontoPignorado as Monto,PorcentajePignora as Porcentaje_Pignorado,CodTipoAhorro,100-PorcentajePignora as Porc_Disp_Pig", "Dui='" & Me.txtDui.Value & "' and Estado='A'", "NoCuenta", sUsuario, sPassword, sSucursal)
                        Me.fg.DataSource = ds.Tables(0)
                        Encabezado()
                        ds = oAh.ConsultarCuentaAhorro("P", "a.Dui='" & Me.txtDui.Value & "' and a.Estado='A' and a.Pignorado='S' and b.Estado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                        Me.fgPignorada.DataSource = ds.Tables(0)
                        EncabezadoPignoradas()
                    End If
                End If

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim pCodTipoAhorro As String, pPorcPig As Double, pDisponible As Double, dr As DataRow
        Dim pMontoPignorado As Double, vSumPign As Double, vTotPorcPig As Double, vPorPigPar As Double

        Try

            If Me.txtDui.Text.Trim = "" Or Me.txtCodPrestamo.Text.Trim = "" Then
                MsgBox("Ingrese el Dui y el Código de Préstamo.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Me.txtNoCuenta.Text.Trim = "" Then
                MsgBox("Debe seleccionar la Cuenta que desea pignorar.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Math.Round(c1nMontoPignorado.Value, 2) > Math.Round(pMaximo, 2) Then
                MsgBox("El Monto Pignorado supera el máximo disponible.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Me.c1nMontoPignorado.Value = 0 Then
                MsgBox("Debe ingresar el Monto Pignorado.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            pCodTipoAhorro = Me.txtCodTipoAhorro.Text.Trim

            ds = oAhorro.ConsultarCuentaPignorada("*", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Estado='N'", "NoCuenta", sUsuario, sPassword, sSucursal)
            For Each dr In ds.Tables("AhPignoraciones").Rows
                pMontoPignorado = pMontoPignorado + dr("MontoPignorado")
                vSumPign = vSumPign + dr("PorcentajePignora")
            Next
            vTotPorcPig = vSumPign

            ds.Clear()
            ds = oAhorro.ConsultarParametros("PorcentajePignoracion", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vPorPigPar = dr("PorcentajePignoracion") / 100
            Else
                vPorPigPar = 0
            End If
            ds.Clear()
            vSumPign = vPorPigPar - (vSumPign / 100)

            If Math.Round(Saldo * vSumPign, 2) < Math.Round(Me.c1nMontoPignorado.Value, 2) Then
                MsgBox("El Máximo de garantía que se puede conceder es de " & Math.Round(Saldo * vSumPign, 2), MsgBoxStyle.Information, "Validación del Sistema")
                Exit Sub
            End If

            pDisponible = Saldo - (pMontoPignorado + Me.c1nMontoPignorado.Value)
            pPorcPig = (Me.c1nMontoPignorado.Value * (vPorPigPar * 100)) / (Saldo * vPorPigPar)

            If oAhorro.ModificarCuentaAhorro(Me.txtNoCuenta.Text.Trim, pCodTipoAhorro, "SaldoDisponible_CuentaAhorro=" & pDisponible & ",Pignorado='S',MontoPignorado=" & pMontoPignorado + Me.c1nMontoPignorado.Value & ",PorcentajePignora=" & pPorcPig + vTotPorcPig & "", sUsuario, sPassword, sSucursal) = True Then

                If oAhorro.InsertarCuentaPignorada("CodTipoAhorro,NoCuenta,CodPrestamo,MontoPignorado,FechaInicioPignora,FechaFinPignora,Estado,PorcentajePignora,usuarioIngresa", "'" & pCodTipoAhorro & "','" & Me.txtNoCuenta.Text.Trim & "','" & Me.txtCodPrestamo.Text.Trim & "'," & Me.c1nMontoPignorado.Value & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "','N'," & pPorcPig & ",'" & sUsuario & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.txtNoCuenta.Text = ""
                    Me.txtCodTipoAhorro.Text = ""
                    Me.c1nMontoPignorado.Value = 0
                    ds = oAhorro.ConsultarCuentaAhorro("NoCuenta,Saldo_CuentaAhorro as Saldo,SaldoDisponible_CuentaAhorro as Disponible_Cuenta,Pignorado as Pignorada,MontoPignorado as Monto,PorcentajePignora as Porcentaje_Pignorado,CodTipoAhorro,100-PorcentajePignora as Porc_Disp_Pig", "Dui='" & Me.txtDui.Value & "' and Estado='A'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fg.DataSource = ds.Tables(0)
                    Encabezado()
                    ds = oAhorro.ConsultarCuentaAhorro("P", "a.Dui='" & Me.txtDui.Value & "' and a.Estado='A' and b.Estado='N' and a.Pignorado='S'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fgPignorada.DataSource = ds.Tables(0)
                    EncabezadoPignoradas()
                End If

            End If

        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow, dsTemp As New DataSet
        Dim pNoCuenta As String, pDisponible As Double, pCodPrestamo As String, pCodTipoAhorro As String
        Dim pMontoPignorado As Double, vSumPign As Double, vTotPorcPig As Double, vPignorado As String, vPorPigPar As Double

        Try
            If Me.fg.Row <> -1 Then

                If CDate(pFecVenc.ToShortDateString) <> CDate(Me.dtpFecVenc.Value.ToShortDateString) Then
                    MessageBox.Show("La fecha de despignoración debe coincidir con la Fecha de Vencimiento del Préstamo.", "Despignoración de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                oAhorro.ModificarCuentaPignorada(Me.fgPignorada.Item(Me.fgPignorada.Row, "Correlativo"), "FechaFinPignora='" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "',Estado='C',usuarioModifica = '" & sUsuario & "',fechaModifica = '" & Format(Now, "Short Date") & "'", sUsuario, sPassword, sSucursal)
                pNoCuenta = Me.fgPignorada.Item(Me.fgPignorada.Row, "NoCuenta")
                pCodPrestamo = Me.fgPignorada.Item(Me.fgPignorada.Row, "CodPrestamo")
                pCodTipoAhorro = Me.fgPignorada.Item(Me.fgPignorada.Row, "CodTipoAhorro")

                dsTemp = oAhorro.ConsultarCuentaAhorro("Saldo_CuentaAhorro as Saldo,SaldoDisponible_CuentaAhorro as Disponible_Cuenta", "NoCuenta='" & pNoCuenta & "' and Estado='A' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                If dsTemp.Tables(0).Rows.Count > 0 Then
                    dr = dsTemp.Tables(0).Rows(0)
                    Saldo = dr("Saldo")
                End If
                ' and CodPrestamo='" & pCodPrestamo & "'
                ds = oAhorro.ConsultarCuentaPignorada("*", "NoCuenta='" & pNoCuenta & "' and Estado='N'", "NoCuenta", sUsuario, sPassword, sSucursal)
                For Each dr In ds.Tables("AhPignoraciones").Rows
                    pMontoPignorado = pMontoPignorado + dr("MontoPignorado")
                    vSumPign = vSumPign + dr("PorcentajePignora")
                Next
                If vSumPign = 0 Then
                    vPignorado = "N"
                Else
                    vPignorado = "S"
                End If

                vTotPorcPig = vSumPign

                ds.Clear()
                ds = oAhorro.ConsultarParametros("PorcentajePignoracion", "CodTipoAhorro='" & pCodTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    vPorPigPar = dr("PorcentajePignoracion") / 100
                Else
                    vPorPigPar = 0
                End If
                ds.Clear()

                vSumPign = vPorPigPar - (vSumPign / 100)

                pDisponible = Saldo - (pMontoPignorado)

                If oAhorro.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, "SaldoDisponible_CuentaAhorro=" & pDisponible & ",Pignorado='" & vPignorado & "',MontoPignorado=" & pMontoPignorado & ",PorcentajePignora=" & vTotPorcPig & "", sUsuario, sPassword, sSucursal) = True Then
                    ds = oAhorro.ConsultarCuentaAhorro("NoCuenta,Saldo_CuentaAhorro as Saldo,SaldoDisponible_CuentaAhorro as Disponible_Cuenta,Pignorado as Pignorada,MontoPignorado as Monto,PorcentajePignora as Porcentaje_Pignorado,CodTipoAhorro,100-PorcentajePignora as Porc_Disp_Pig", "Dui='" & Me.txtDui.Value & "' and Estado='A'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fg.DataSource = ds.Tables(0)
                    Encabezado()

                    ds = oAhorro.ConsultarCuentaAhorro("P", "a.Dui='" & Me.txtDui.Value & "' and a.Estado='A' and b.Estado='N' and a.Pignorado='S'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fgPignorada.DataSource = ds.Tables(0)
                    EncabezadoPignoradas()
                End If
                MsgBox("Cuenta Despignorada")
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ds As New DataSet
            Me.txtAsociado.Text = ""
            Me.txtNoSocio.Text = ""
            Me.txtDui.Text = ""
            Me.txtDui.Value = ""
            Me.txtCodPrestamo.Text = ""
            Me.txtNoCuenta.Text = ""
            Me.txtCodTipoAhorro.Text = ""
            Me.lblMonto.Text = "Monto máximo de cobertura: $0.00"
            Me.lblMax.Text = "Porcentaje a pignorar: %0.00"
            Me.c1nMontoPignorado.Value = 0
            pSaldo = 0
            pDisponible = 0
            pMaximo = 0
            fg.DataSource = ds
            fgPignorada.DataSource = ds
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Dim sTexto As String
            Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
            Try
                oPrest = New wrPrestamo.wsLibPrest
                sTexto = Me.txtCodPrestamo.Text
                If sTexto = "" Then

                ElseIf sTexto <> "" Then
                    ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                    Me.dtpFecVenc.Value = IIf(IsDBNull(dr("FechaVencimiento")), Now, dr("FechaVencimiento"))
                    pFecVenc = Me.dtpFecVenc.Value
                End If
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: NO EXISTE EL CODIGO DE PRESTAMO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub fgPignorada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fgPignorada.Click
        If Me.fgPignorada.Row <> -1 Then
            pFecVenc = Me.fgPignorada.Item(Me.fgPignorada.Row, "Vencimiento")
        End If
    End Sub

    Private Sub c1nMontoPignorado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMontoPignorado.LostFocus
        Me.lblMax.Text = "Porcentaje a pignorar: " & CStr(Math.Round((Me.c1nMontoPignorado.Value / (Saldo * vSumPignoradoxCuenta)) * 100, 2)) & "%"
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim sTexto As String
        If Me.txtDui.Text.Trim = "" Then Exit Sub

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim oAh As New wrAhorro.wsLibAhorro
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                    ds = oAh.ConsultarCuentaAhorro("NoCuenta,Saldo_CuentaAhorro as Saldo,SaldoDisponible_CuentaAhorro as Disponible_Cuenta,Pignorado as Pignorada,MontoPignorado as Monto,PorcentajePignora as Porcentaje_Pignorado,CodTipoAhorro,100-PorcentajePignora as Porc_Disp_Pig", "Dui='" & Me.txtDui.Value & "' and Estado='A'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fg.DataSource = ds.Tables(0)
                    Encabezado()
                    ds = oAh.ConsultarCuentaAhorro("P", "a.Dui='" & Me.txtDui.Value & "' and a.Estado='A' and a.Pignorado='S' and b.Estado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                    Me.fgPignorada.DataSource = ds.Tables(0)
                    EncabezadoPignoradas()
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

End Class