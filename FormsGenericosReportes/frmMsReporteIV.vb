Public Class frmMsReporteIV
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Dim caja As New wrCaja.wsLibCaja
    Private vTitulo As String, vNumReporte As String, vOpcion As wrAhorro.TiposAhorroReporteMovimientos
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbOpciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbOpciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 32)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Para visualizar impresión debe seleccionar una opción, digitar la fecha y el núme" &
    "ro de factura."
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNumero.Location = New System.Drawing.Point(328, 55)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(104, 21)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(240, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "No. Factura:"
        '
        'cbOpciones
        '
        Me.cbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOpciones.Items.AddRange(New Object() {"Depósitos de Ahorro a la Vista", "Depósitos de Ahorro Restringido", "Depósitos de Ahorro Programado", "Depósitos de Aportación", "Aperturas DPF", "Retiros de Ahorros", "Ingresos de Asociados", "Pago Préstamos", "Abono de Cuentas Contables", "Cancelación DPF", "Pago Préstamos (Aplicación Valor Fecha)", "Retiros de Ahorros (Aplicación Valor Fecha)", "Depósitos de Ahorro a la Vista (Aplicación Valor Fecha)", "Depósitos de Ahorro Restringido (Aplicación Valor Fecha)", "Depósitos de Ahorro Programado (Aplicación Valor Fecha)", "Depósitos de Aportación (Aplicación Valor Fecha)", "Cargo de Cuentas Contables", "Apertura Préstamos"})
        Me.cbOpciones.Location = New System.Drawing.Point(8, 24)
        Me.cbOpciones.Name = "cbOpciones"
        Me.cbOpciones.Size = New System.Drawing.Size(424, 21)
        Me.cbOpciones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Seleccione una opción:"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(8, 56)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 16)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(64, 56)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(315, 197)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1027
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(396, 197)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 1028
        Me.MetroButton1.Text = "Imprimir"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsReporteIV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(514, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteIV"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Facturas Consolidadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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

    Public Property Opcion() As wrAhorro.TiposAhorroReporteMovimientos
        Get
            Return vOpcion
        End Get
        Set(ByVal Value As wrAhorro.TiposAhorroReporteMovimientos)
            vOpcion = Value
        End Set
    End Property

#End Region


    Protected Sub correlativoFactura()
        Dim dtsCorr As New DataSet
        dtsCorr = caja.consultarCaCorrelativoCaja("01", 0, 1, 0, 3)
        Dim maximo As Integer
        If dtsCorr.Tables.Count > 0 Then
            If dtsCorr.Tables(0).Rows.Count > 0 Then
                maximo = dtsCorr.Tables(0).Rows(0).Item("maximo")
                If dtsCorr.Tables(0).Rows(0).Item("correlativo") < maximo Then
                    Me.txtNumero.Text = dtsCorr.Tables(0).Rows(0).Item("correlativo") + 1
                End If
            End If
        End If
    End Sub
    Private Sub frmMsReporteIV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.Text = Me.Titulo
        Me.cbOpciones.SelectedIndex = 0
        correlativoFactura()
    End Sub



    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case "0"  'GENERACIÓN DE FACTURA CONSOLIDADA (MOVIMIENTOS DIARIOS)
                    Dim oFact As New wrCaja.wsLibCaja, pResp As String
                    pResp = oFact.FacturaConsolidada(Format(Me.dtpFecha.Value, "short date"), Me.txtNumero.Text.Trim, Me.cbOpciones.SelectedIndex, sUsuario, sPassword, sSucursal)
                    If pResp.Trim = "" Then
                        MessageBox.Show("Factura consolidada generada con éxito.", "Factura Consolidada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        correlativoFactura()
                    Else
                        MessageBox.Show(pResp, "Factura Consolidada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try

            If Me.txtNumero.Text.Trim = "" Then
                MessageBox.Show("Debe digitar el número de factura.", "Factura Consolidada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet
            ds = oCaja.RepTransferenciasConsolidada(Me.txtNumero.Text.Trim, Me.dtpFecha.Value, Me.cbOpciones.SelectedIndex, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 74, 0)
            ofrm.ShowDialog()
            correlativoFactura()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbOpciones_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOpciones.DropDownClosed
        correlativoFactura()
    End Sub

    Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
        correlativoFactura()
    End Sub
End Class