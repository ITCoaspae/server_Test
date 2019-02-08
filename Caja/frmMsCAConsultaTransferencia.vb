Public Class frmMsCAConsultaTransferencia
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim CCodCosto As String = ""
    'Private sNoCuenta As String, pSaldoOrigen As Double, pPignorado As String, vCancela As Boolean, pCodTransaccion As String
    Public pCodTransferencia As String, pEstado As String
    Private dsDetalle As New DataSet
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Public pTipoTransferencia As String

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
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c1txtNoDoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombreAsoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCAConsultaTransferencia))
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1txtNoDoc = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1txtNombreAsoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.gbDestino.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDestino
        '
        Me.gbDestino.BackColor = System.Drawing.Color.White
        Me.gbDestino.Controls.Add(Me.fg)
        Me.gbDestino.ForeColor = System.Drawing.Color.Teal
        Me.gbDestino.Location = New System.Drawing.Point(23, 303)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(648, 191)
        Me.gbDestino.TabIndex = 1
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Cuenta(s) de Destino:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AutoResize = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(9, 19)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(618, 166)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCodTipo)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.c1txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c1txtNoDoc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.c1txtNombreAsoc)
        Me.GroupBox1.Controls.Add(Me.c1txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 234)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de Origen"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstado.Location = New System.Drawing.Point(483, 54)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(144, 13)
        Me.txtEstado.TabIndex = 168
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEstado.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(286, 149)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(341, 20)
        Me.txtCuenta.TabIndex = 166
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.BackColor = System.Drawing.Color.White
        Me.txtIdCuenta.Location = New System.Drawing.Point(112, 149)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(168, 20)
        Me.txtIdCuenta.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Cuenta Contable:"
        '
        'txtCodTipo
        '
        Me.txtCodTipo.BackColor = System.Drawing.Color.Khaki
        Me.txtCodTipo.Location = New System.Drawing.Point(286, 72)
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(8, 20)
        Me.txtCodTipo.TabIndex = 164
        Me.txtCodTipo.Visible = False
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.Location = New System.Drawing.Point(307, 19)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(320, 20)
        Me.txtResponsable.TabIndex = 1
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 71)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(168, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(459, 73)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(168, 20)
        Me.txtNoSocio.TabIndex = 163
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Asociado:"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(365, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(213, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Responsable:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BackColor = System.Drawing.Color.White
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(112, 175)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ReadOnly = True
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(515, 48)
        Me.c1txtObservaciones.TabIndex = 6
        Me.c1txtObservaciones.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Observaciones:"
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BackColor = System.Drawing.Color.White
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.Location = New System.Drawing.Point(112, 45)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.ReadOnly = True
        Me.c1txtNoDoc.Size = New System.Drawing.Size(168, 20)
        Me.c1txtNoDoc.TabIndex = 2
        Me.c1txtNoDoc.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "No. Documento:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(304, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Valor Transferencia:"
        '
        'c1txtCuenta
        '
        Me.c1txtCuenta.BackColor = System.Drawing.Color.White
        Me.c1txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtCuenta.Location = New System.Drawing.Point(112, 123)
        Me.c1txtCuenta.MaxLength = 14
        Me.c1txtCuenta.Name = "c1txtCuenta"
        Me.c1txtCuenta.NumericInput = False
        Me.c1txtCuenta.ReadOnly = True
        Me.c1txtCuenta.Size = New System.Drawing.Size(168, 20)
        Me.c1txtCuenta.TabIndex = 4
        Me.c1txtCuenta.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Cuenta:"
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.BackColor = System.Drawing.Color.White
        Me.c1txtNombreAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(112, 97)
        Me.c1txtNombreAsoc.MaxLength = 14
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.NumericInput = False
        Me.c1txtNombreAsoc.ReadOnly = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(515, 20)
        Me.c1txtNombreAsoc.TabIndex = 94
        Me.c1txtNombreAsoc.Tag = Nothing
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BackColor = System.Drawing.Color.White
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.Increment = 1.0R
        Me.c1txtMonto.Location = New System.Drawing.Point(459, 123)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.ReadOnly = True
        Me.c1txtMonto.ShowDropDownButton = False
        Me.c1txtMonto.ShowUpDownButtons = False
        Me.c1txtMonto.Size = New System.Drawing.Size(168, 21)
        Me.c1txtMonto.TabIndex = 5
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "DUI:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(112, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Movimiento:"
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(596, 500)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 152
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(515, 500)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 151
        Me.btNProcesar1.Text = "Anular"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'frmMsCAConsultaTransferencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(684, 560)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDestino)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(684, 560)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(684, 560)
        Me.Name = "frmMsCAConsultaTransferencia"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Transferencia Cuentas Auxiliares"
        Me.gbDestino.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "No. Cuenta"
        fg.Cols.Item(3).Caption = "Cta. Contable"
        fg.Cols.Item(4).Caption = "Valor"
        fg.Cols.Item(5).Caption = "Tipo Movimiento"
        fg.Cols.Item(6).Caption = "Tipo Cuenta"
        fg.Cols.Item(4).Format = "##0.00"

        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 0
        fg.Cols.Item(6).Width = 0

    End Sub



    Private Function VerificaPrestamo() As Boolean
        Dim pSum As Double, dr As DataRow

        For Each dr In dsDetalle.Tables(0).Rows
            If Trim(dr("TipoCuenta")) = "P" Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function VerificaAhorro() As Boolean
        Dim pSum As Double, dr As DataRow

        For Each dr In dsDetalle.Tables(0).Rows
            If Trim(dr("TipoCuenta")) = "A" Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub frmMsCAConsultaTransferencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet, dr As DataRow, dsTemp As New DataSet
        dsDetalle = oAh.ObtenerDetalleTransferenciaVacio
        dsTemp = dsDetalle
        ds = oAh.ConsultarTransferencia("b.NoCuenta,b.IdCuenta,b.TipoCuenta,b.TipoMovimiento,b.Valor,b.Tipo,b.Fecha", "a.CodTransferencia='" & Me.pCodTransferencia & "' and a.Fecha='" & Me.dtpFecha.Value.ToShortDateString & "'", "b.Tipo desc", pTipoTransferencia, sUsuario, sPassword, sSucursal)
        If pEstado = "A" Then
            Me.txtEstado.Visible = True
            Me.txtEstado.Text = "Anulada"
        Else
            Me.txtEstado.Visible = False
        End If
        For Each dr In ds.Tables(0).Rows
            If dr("Tipo") = "C" Then
                Me.c1txtCuenta.Value = dr("NoCuenta")
                Me.txtIdCuenta.Text = dr("IdCuenta")
            ElseIf dr("Tipo") = "A" Then
                dsTemp = oAh.AgregarDetalleTransferencia(dsTemp, dsTemp.Tables(0).Rows.Count + 1, dr("NoCuenta"), dr("Valor"), dr("TipoMovimiento"), dr("TipoCuenta"), dr("IdCuenta"), dr("Fecha"), CCodCosto)
            End If
        Next
        dsDetalle = dsTemp
        fg.DataSource = dsDetalle.Tables(0)
        fg.Refresh()
        Encabezado()
    End Sub



    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Try
            Dim oApp As New wrAdmin.wsLibAdmin, dr As DataRow

            If pEstado.Trim = "A" Then
                MessageBox.Show("La Transferencia ya se encuentra anulada.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CDate(oApp.Fecha.ToShortDateString) = CDate(Me.dtpFecha.Value.ToShortDateString) Then

                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "CAK002"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    If MessageBox.Show("¿Está seguro que desea anular la transferencia?", "Validación del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim oCaja As New wrCaja.wsLibCaja, pResp As String, oAh As New wrAhorro.wsLibAhorro
                        pResp = oCaja.CorrelativoReversionTransferencia
                        If pResp.Trim <> "" Then
                            If VerificaPrestamo() = False Then
                                pResp = oAh.ReversionMovimientosxTransferencia(pCodTransferencia, Me.dtpFecha.Value, oApp.Fecha, pResp, 0, 0, "", ofrmAut.Usuario, ofrmAut.Password, sSucursal)
                                If pResp.Trim = "" Then
                                    pResp = oCaja.ReversionTransferencia(pCodTransferencia, Me.dtpFecha.Value, oApp.Fecha, 0, 0, "", ofrmAut.Usuario, ofrmAut.Password, sSucursal)
                                    MessageBox.Show("Reversión realizada con éxito.", "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("Error al realizar la reversión. " & pResp, "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                'Dim pCodReversion As String
                                'AbonoPrestamo
                                'pCodReversion = "RMC" & Format(Month(oApp.Fecha), "00") & Year(oApp.Fecha) & oCred.CorrelativoReversion(ofrmAut.Usuario, ofrmAut.Password)
                                'pResp = oCred.ReversionProvisiones(pCodReversion, pNoCuenta, oApp.Fecha.ToShortDateString, "C", Val(Me.txtTotalFactura.Text), pIdMovimiento, "", ofrmAut.Usuario, ofrmAut.Password)
                            End If
                        Else
                            MessageBox.Show("Error al realizar la reversión, verifíque.", "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            Else
                MessageBox.Show("Para ser anulada la transferencia debe tener fecha de hoy.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try

            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "CAJ009"
            ofrmAut.TopMost = True
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Dim ds As New DataSet, dst As New DataSet
                Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
                If VerificaPrestamo() = False Then
                    If VerificaAhorro() = True Then
                        ds = oCaja.NotaCargo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                        Dim ofrm As New frmVisor(ds, 56, 0)
                        ofrm.TopMost = True
                        ofrm.ShowDialog()

                    Else
                        ds = oCaja.NotaCargoContable(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                        Dim ofrm As New frmVisor(ds, 56, 0)
                        ofrm.TopMost = True
                        ofrm.ShowDialog()
                    End If
                Else
                    ds = oCaja.NotaCargoPrestamo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count <= 0 Then
                        dst = oCaja.NotaCargoContable(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                        Dim ofrm As New frmVisor(dst, 56, 0)
                        ofrm.TopMost = True
                        ofrm.ShowDialog()
                    Else
                        Dim ofrm As New frmVisor(ds, 58, 0)
                        ofrm.TopMost = True
                        ofrm.ShowDialog()
                    End If
                End If
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class