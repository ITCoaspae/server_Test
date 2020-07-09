Public Class frmMClasifRiesgo
    Inherits MetroFramework.Forms.MetroForm '
    Public rsc As System.Resources.ResourceManager

    Private dsPrestamo As DataSet, vIdPrestamo As String
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPartidaReserva1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCalificaRiesgo1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDetalles1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents optPlazo As System.Windows.Forms.RadioButton
    Friend WithEvents optMonto As System.Windows.Forms.RadioButton
    Friend WithEvents optCodAsoc As System.Windows.Forms.RadioButton
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NENumPagos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtalNoAsoc As System.Windows.Forms.TextBox
    Friend WithEvents txtdelNoAsoc As System.Windows.Forms.TextBox
    Friend WithEvents optTodos As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMClasifRiesgo))
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        Me.optTodos = New System.Windows.Forms.RadioButton()
        Me.C1NENumPagos = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtalNoAsoc = New System.Windows.Forms.TextBox()
        Me.txtdelNoAsoc = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optPlazo = New System.Windows.Forms.RadioButton()
        Me.optMonto = New System.Windows.Forms.RadioButton()
        Me.optCodAsoc = New System.Windows.Forms.RadioButton()
        Me.btnPartidaReserva1 = New MetroFramework.Controls.MetroButton()
        Me.btnCalificaRiesgo1 = New MetroFramework.Controls.MetroButton()
        Me.btnDetalles1 = New MetroFramework.Controls.MetroButton()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(28, 263)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(776, 162)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar1)
        Me.GroupBox2.Controls.Add(Me.optTodos)
        Me.GroupBox2.Controls.Add(Me.C1NENumPagos)
        Me.GroupBox2.Controls.Add(Me.C1NEMonto)
        Me.GroupBox2.Controls.Add(Me.txtalNoAsoc)
        Me.GroupBox2.Controls.Add(Me.txtdelNoAsoc)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.optPlazo)
        Me.GroupBox2.Controls.Add(Me.optMonto)
        Me.GroupBox2.Controls.Add(Me.optCodAsoc)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 131)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Préstamo por:"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(588, 65)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(90, 32)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 196
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'optTodos
        '
        Me.optTodos.BackColor = System.Drawing.Color.White
        Me.optTodos.Location = New System.Drawing.Point(588, 28)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(86, 27)
        Me.optTodos.TabIndex = 19
        Me.optTodos.Text = "Todos"
        Me.optTodos.UseVisualStyleBackColor = False
        '
        'C1NENumPagos
        '
        Me.C1NENumPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NENumPagos.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NENumPagos.CustomFormat = "##0"
        Me.C1NENumPagos.DataType = GetType(Short)
        Me.C1NENumPagos.Enabled = False
        Me.C1NENumPagos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NENumPagos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NENumPagos.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NENumPagos.Location = New System.Drawing.Point(398, 65)
        Me.C1NENumPagos.MaxLength = 3
        Me.C1NENumPagos.Name = "C1NENumPagos"
        Me.C1NENumPagos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NENumPagos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NENumPagos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NENumPagos.Size = New System.Drawing.Size(183, 26)
        Me.C1NENumPagos.TabIndex = 18
        Me.C1NENumPagos.Tag = Nothing
        Me.C1NENumPagos.Value = CType(0, Short)
        Me.C1NENumPagos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Enabled = False
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(209, 63)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(182, 27)
        Me.C1NEMonto.TabIndex = 17
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtalNoAsoc
        '
        Me.txtalNoAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalNoAsoc.Enabled = False
        Me.txtalNoAsoc.Location = New System.Drawing.Point(67, 92)
        Me.txtalNoAsoc.Name = "txtalNoAsoc"
        Me.txtalNoAsoc.Size = New System.Drawing.Size(135, 22)
        Me.txtalNoAsoc.TabIndex = 16
        '
        'txtdelNoAsoc
        '
        Me.txtdelNoAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelNoAsoc.Enabled = False
        Me.txtdelNoAsoc.Location = New System.Drawing.Point(67, 65)
        Me.txtdelNoAsoc.Name = "txtdelNoAsoc"
        Me.txtdelNoAsoc.Size = New System.Drawing.Size(135, 22)
        Me.txtdelNoAsoc.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(209, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(134, 27)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(29, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Al"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(29, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Del"
        '
        'optPlazo
        '
        Me.optPlazo.BackColor = System.Drawing.Color.White
        Me.optPlazo.Location = New System.Drawing.Point(398, 28)
        Me.optPlazo.Name = "optPlazo"
        Me.optPlazo.Size = New System.Drawing.Size(183, 27)
        Me.optPlazo.TabIndex = 3
        Me.optPlazo.Text = "Plazo"
        Me.optPlazo.UseVisualStyleBackColor = False
        '
        'optMonto
        '
        Me.optMonto.BackColor = System.Drawing.Color.White
        Me.optMonto.Location = New System.Drawing.Point(209, 28)
        Me.optMonto.Name = "optMonto"
        Me.optMonto.Size = New System.Drawing.Size(182, 27)
        Me.optMonto.TabIndex = 2
        Me.optMonto.Text = "Monto Otorgado"
        Me.optMonto.UseVisualStyleBackColor = False
        '
        'optCodAsoc
        '
        Me.optCodAsoc.BackColor = System.Drawing.Color.White
        Me.optCodAsoc.Location = New System.Drawing.Point(19, 28)
        Me.optCodAsoc.Name = "optCodAsoc"
        Me.optCodAsoc.Size = New System.Drawing.Size(183, 27)
        Me.optCodAsoc.TabIndex = 1
        Me.optCodAsoc.Text = "DUI de Asociado"
        Me.optCodAsoc.UseVisualStyleBackColor = False
        '
        'btnPartidaReserva1
        '
        Me.btnPartidaReserva1.Location = New System.Drawing.Point(253, 224)
        Me.btnPartidaReserva1.Name = "btnPartidaReserva1"
        Me.btnPartidaReserva1.Size = New System.Drawing.Size(150, 32)
        Me.btnPartidaReserva1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPartidaReserva1.TabIndex = 197
        Me.btnPartidaReserva1.Text = "Partida Reserva"
        Me.btnPartidaReserva1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnPartidaReserva1.UseSelectable = True
        Me.btnPartidaReserva1.UseStyleColors = True
        '
        'btnCalificaRiesgo1
        '
        Me.btnCalificaRiesgo1.Location = New System.Drawing.Point(125, 224)
        Me.btnCalificaRiesgo1.Name = "btnCalificaRiesgo1"
        Me.btnCalificaRiesgo1.Size = New System.Drawing.Size(121, 32)
        Me.btnCalificaRiesgo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCalificaRiesgo1.TabIndex = 196
        Me.btnCalificaRiesgo1.Text = "Calificar Riesgo"
        Me.btnCalificaRiesgo1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCalificaRiesgo1.UseSelectable = True
        Me.btnCalificaRiesgo1.UseStyleColors = True
        '
        'btnDetalles1
        '
        Me.btnDetalles1.Location = New System.Drawing.Point(28, 224)
        Me.btnDetalles1.Name = "btnDetalles1"
        Me.btnDetalles1.Size = New System.Drawing.Size(90, 32)
        Me.btnDetalles1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDetalles1.TabIndex = 195
        Me.btnDetalles1.Text = "Detalle"
        Me.btnDetalles1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDetalles1.UseSelectable = True
        Me.btnDetalles1.UseStyleColors = True
        '
        'frmMClasifRiesgo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(831, 491)
        Me.Controls.Add(Me.btnPartidaReserva1)
        Me.Controls.Add(Me.btnCalificaRiesgo1)
        Me.Controls.Add(Me.btnDetalles1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.Name = "frmMClasifRiesgo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Clasificación por Riesgo"
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Public Property IdPrestamo() As String
        Get
            Return vIdPrestamo
        End Get
        Set(ByVal Value As String)
            vIdPrestamo = Value
        End Set
    End Property
#End Region

    Private Sub frmMPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oPrestamos As New wrPrestamo.wsLibPrest
        Dim dsPrest As New DataSet
        Try
            dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdPrestamos.DataSource = dsPrest.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub C1fgrdPrestamos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1fgrdPrestamos.DoubleClick
        Me.btnDetalles1_Click(sender, e)
    End Sub

    Private Sub btnCalculadoraTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmCRTablaAmort
        ofrm.btnAsignar1.Visible = False
        ofrm.ShowDialog()
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim oPrestamos As New wrPrestamo.wsLibPrest
        Dim dsPrest As New DataSet
        Try
            If Me.optCodAsoc.Checked = True Then
                dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "a.Dui>='" & Me.txtdelNoAsoc.Text & "' and a.Dui<='" & Me.txtalNoAsoc.Text & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ElseIf Me.optMonto.Checked = True Then
                dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "a.Monto>=" & Me.C1NEMonto.Value & "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ElseIf Me.optPlazo.Checked = True Then
                dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "a.PlazoMeses= " & Me.C1NENumPagos.Value & "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ElseIf Me.optTodos.Checked = True Then
                dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            End If
            C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdPrestamos.DataSource = dsPrest.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub optPlazo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPlazo.CheckedChanged
        Me.C1NENumPagos.Enabled = Me.optPlazo.Checked
        Me.C1NENumPagos.Focus()
    End Sub

    Private Sub optMonto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMonto.CheckedChanged
        Me.C1NEMonto.Enabled = Me.optMonto.Checked
        Me.C1NEMonto.Focus()
    End Sub

    Private Sub optCodAsoc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCodAsoc.CheckedChanged
        Me.txtdelNoAsoc.Enabled = Me.optCodAsoc.Checked
        Me.txtalNoAsoc.Enabled = Me.optCodAsoc.Checked
        Me.txtdelNoAsoc.Focus()
    End Sub

    Private Sub C1fgrdPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1fgrdPrestamos.Click
        Me.IdPrestamo = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodPrestamo")
    End Sub



    Private Sub txtalNoAsoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalNoAsoc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    End Sub

    Private Sub txtdelNoAsoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdelNoAsoc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    End Sub

    Private Sub C1NENumPagos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1NENumPagos.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    End Sub

    Private Sub btnDetalles1_Click(sender As Object, e As EventArgs) Handles btnDetalles1.Click
        Try
            Dim ofrm As New frmMsCRDetPrestamo
            ofrm.IdPrestamo = Me.IdPrestamo.Trim
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCalificaRiesgo1_Click(sender As Object, e As EventArgs) Handles btnCalificaRiesgo1.Click
        Dim oPrestamos As New wrPrestamo.wsLibPrest
        Dim dsPrest As New DataSet
        Try
            If oPrestamos.CalificaRiesgo(sUsuario, sPassword, sSucursal) = True Then
                MessageBox.Show("Proceso Realizado con Éxito", "SIF_ERP", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                dsPrest = oPrestamos.ConsultarPRPrestamosCategoria("a.CodPrestamo, a.CodAnteriorPrestamo, a.NoSocio, a.DUI,a.DiasMora,a.GeneraReserva, a.FechaOtorgamiento, a.FechaVencimiento, round(a.Monto,2) as Monto, round(a.Saldo_Capital,2) as Saldo_Capital, round(a.SaldoDia_CapitalMora,2) as SaldoDia_CapitalMora, a.Categoria,round(b.PorcentajeRiesgo,2) as PorcentajeRiesgo", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                C1fgrdPrestamos.DataSource = dsPrest.Tables(0)
            Else
                MessageBox.Show("Proceso no se realizó con éxito", "SIF_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPartidaReserva1_Click(sender As Object, e As EventArgs) Handles btnPartidaReserva1.Click
        Dim oPres As New wrPrestamo.wsLibPrest, dsPrest As DataSet
        Dim ofrm As New frmPartida, dsDetP As System.Data.DataSet
        Dim oLib As New wrConta.wsLibContab
        'Dim NoPartida As String, 
        Dim pFecha As Date
        Try

            'ofrm.Tipo = Contabilidad.clsPartida.TipoPartidaModulo.ReservaRiesgo
            ofrm.txtConcepto.Text = "Aplicación de Política de Riesgos"
            ofrm.txtDescripcion.Text = "Aplicación de Política de Riesgos"
            dsDetP = oLib.ObtenerPartidaVacia(sUsuario, sPassword, sSucursal)
            pFecha = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            dsPrest = oPres.GeneraPartidaReserva(pFecha, sUsuario, sPassword, sSucursal)
            dsPrest.WriteXml("c:\dsReserva.xml")

            'Dim dr As System.Data.DataRow = dsDetP.Tables("Det_Diario").NewRow
            'dr("Correl") = 1
            'dr("IdCuenta") = ""
            'dr("CodCosto") = ""
            'dr("CodBeneficio") = ""
            'dr("Descripcion") = ""
            'dr("Cargo") = "0"
            'dr("Abono") = 0
            'ofrm.txtTotalAbonos.Text = 0
            'ofrm.cmbTipoPartidas.Text = "DR - COMPROBANTES DE DIARIO"
            'dr("Concepto") = "Aplicación de Política de Riesgos"
            'ofrm.drNueva = dr
            'ofrm.ShowDialog()
            'NoPartida = ofrm.txtNumero.Text

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1NEMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1NEMonto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    End Sub

End Class