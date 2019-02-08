Public Class frmMsCBReversion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents gbOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents rbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbCaja As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodReversion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents rbReversion As System.Windows.Forms.RadioButton
    Friend WithEvents btnReimpresion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.gbOrigen = New System.Windows.Forms.GroupBox()
        Me.rbReversion = New System.Windows.Forms.RadioButton()
        Me.rbTransferencia = New System.Windows.Forms.RadioButton()
        Me.rbCaja = New System.Windows.Forms.RadioButton()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodReversion = New System.Windows.Forms.TextBox()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.rbAbono = New System.Windows.Forms.RadioButton()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReimpresion1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOrigen.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(366, 243)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(8, 20)
        Me.txtOrigen.TabIndex = 184
        Me.txtOrigen.Visible = False
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(374, 243)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(8, 20)
        Me.txtAnio.TabIndex = 183
        Me.txtAnio.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(382, 243)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(8, 20)
        Me.txtTipo.TabIndex = 182
        Me.txtTipo.Visible = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(133, 164)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(157, 20)
        Me.txtDui.TabIndex = 2
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(23, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 181
        Me.Label14.Text = "DUI:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(396, 164)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(155, 20)
        Me.txtNoSocio.TabIndex = 180
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(306, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 178
        Me.Label8.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(133, 190)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(418, 21)
        Me.txtAsociado.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Fecha Movimiento:"
        '
        'dtpDia
        '
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(133, 217)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(157, 20)
        Me.dtpDia.TabIndex = 3
        '
        'gbOrigen
        '
        Me.gbOrigen.Controls.Add(Me.rbReversion)
        Me.gbOrigen.Controls.Add(Me.rbTransferencia)
        Me.gbOrigen.Controls.Add(Me.rbCaja)
        Me.gbOrigen.Enabled = False
        Me.gbOrigen.ForeColor = System.Drawing.Color.Teal
        Me.gbOrigen.Location = New System.Drawing.Point(23, 112)
        Me.gbOrigen.Name = "gbOrigen"
        Me.gbOrigen.Size = New System.Drawing.Size(528, 43)
        Me.gbOrigen.TabIndex = 1
        Me.gbOrigen.TabStop = False
        Me.gbOrigen.Text = "Origen del documento:"
        '
        'rbReversion
        '
        Me.rbReversion.ForeColor = System.Drawing.Color.Black
        Me.rbReversion.Location = New System.Drawing.Point(96, 16)
        Me.rbReversion.Name = "rbReversion"
        Me.rbReversion.Size = New System.Drawing.Size(80, 24)
        Me.rbReversion.TabIndex = 2
        Me.rbReversion.Text = "&Reversión"
        '
        'rbTransferencia
        '
        Me.rbTransferencia.ForeColor = System.Drawing.Color.Black
        Me.rbTransferencia.Location = New System.Drawing.Point(182, 16)
        Me.rbTransferencia.Name = "rbTransferencia"
        Me.rbTransferencia.Size = New System.Drawing.Size(104, 24)
        Me.rbTransferencia.TabIndex = 1
        Me.rbTransferencia.Text = "&Transferencia"
        '
        'rbCaja
        '
        Me.rbCaja.Checked = True
        Me.rbCaja.ForeColor = System.Drawing.Color.Black
        Me.rbCaja.Location = New System.Drawing.Point(16, 16)
        Me.rbCaja.Name = "rbCaja"
        Me.rbCaja.Size = New System.Drawing.Size(48, 24)
        Me.rbCaja.TabIndex = 0
        Me.rbCaja.TabStop = True
        Me.rbCaja.Text = "Ca&ja"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(133, 269)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(418, 32)
        Me.txtObs.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Observaciones:"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.Location = New System.Drawing.Point(133, 243)
        Me.txtNoDocumento.MaxLength = 20
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(157, 20)
        Me.txtNoDocumento.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "No. Documento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCodReversion)
        Me.GroupBox2.Controls.Add(Me.rbCargo)
        Me.GroupBox2.Controls.Add(Me.rbAbono)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 43)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de operación:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(166, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Código de Reversión:"
        '
        'txtCodReversion
        '
        Me.txtCodReversion.Location = New System.Drawing.Point(292, 15)
        Me.txtCodReversion.MaxLength = 25
        Me.txtCodReversion.Name = "txtCodReversion"
        Me.txtCodReversion.Size = New System.Drawing.Size(230, 20)
        Me.txtCodReversion.TabIndex = 85
        '
        'rbCargo
        '
        Me.rbCargo.ForeColor = System.Drawing.Color.Black
        Me.rbCargo.Location = New System.Drawing.Point(96, 19)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(56, 16)
        Me.rbCargo.TabIndex = 1
        Me.rbCargo.Text = "&Cargo"
        '
        'rbAbono
        '
        Me.rbAbono.Checked = True
        Me.rbAbono.ForeColor = System.Drawing.Color.Black
        Me.rbAbono.Location = New System.Drawing.Point(16, 19)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(64, 16)
        Me.rbAbono.TabIndex = 0
        Me.rbAbono.TabStop = True
        Me.rbAbono.Text = "&Abono"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(396, 243)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.ShowDropDownButton = False
        Me.C1NEMonto.ShowUpDownButtons = False
        Me.C1NEMonto.Size = New System.Drawing.Size(155, 21)
        Me.C1NEMonto.TabIndex = 6
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(296, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(294, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código Préstamo:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(396, 217)
        Me.txtCodPrestamo.MaxLength = 25
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(155, 20)
        Me.txtCodPrestamo.TabIndex = 4
        '
        'btnReimpresion1
        '
        Me.btnReimpresion1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnReimpresion1.Location = New System.Drawing.Point(254, 307)
        Me.btnReimpresion1.Name = "btnReimpresion1"
        Me.btnReimpresion1.Size = New System.Drawing.Size(135, 28)
        Me.btnReimpresion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnReimpresion1.TabIndex = 1018
        Me.btnReimpresion1.Text = "&Imprimir nuevamente"
        Me.btnReimpresion1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnReimpresion1.UseSelectable = True
        Me.btnReimpresion1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnImprimir1.Location = New System.Drawing.Point(395, 307)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 1019
        Me.btnImprimir1.Text = "&Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btProcesar1
        '
        Me.btProcesar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btProcesar1.Location = New System.Drawing.Point(476, 307)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 1020
        Me.btProcesar1.Text = "&Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmMsCBReversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(574, 371)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnReimpresion1)
        Me.Controls.Add(Me.gbOrigen)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDia)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoDocumento)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 371)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 371)
        Me.Name = "frmMsCBReversion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicaciones Valor Fecha (Reversiones)"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOrigen.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim pCodReversion As String, pTipoOper As String, pReimpresion As Boolean


    Private Sub Limpiar()
        Me.txtCodPrestamo.Text = ""
        Me.txtNoDocumento.Text = ""
        Me.C1NEMonto.Value = 0
        Me.txtObs.Text = ""
        Me.txtCodReversion.Text = ""
        Me.txtDui.Text = ""
        Me.txtAsociado.Text = ""
        Me.txtNoSocio.Text = ""
        Me.txtAnio.Text = ""
        Me.txtTipo.Text = ""
        Me.dtpDia.Focus()
    End Sub

    Private Sub dtpDia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            oCred = New wrPrestamo.wsLibPrest
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpDia_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            oCred = New wrPrestamo.wsLibPrest
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCargo.CheckedChanged
        Try
            Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            oCred = New wrPrestamo.wsLibPrest
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbAbono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAbono.CheckedChanged
        Try
            Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            oCred = New wrPrestamo.wsLibPrest
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsPRReversion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pTipoOper = "A"
        Me.dtpDia.Value = Now
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
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoDocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDocumento.DoubleClick
        If Me.rbAbono.Checked = True Then Exit Sub

        Dim frm As New frmAGenerico, oAhorro As New wrAhorro.wsLibAhorro
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet ', dr As DataRow, 
        Dim pFecha As Date

        If Me.txtCodPrestamo.Text.Trim = "" Then Exit Sub

        frm.Text = "Buscar Documento"

        Try
            If Me.rbCaja.Checked = True Then

                ds = oCaja.ConsultarEncabezadoDetalleFacturasxFiltro("a.IdMovimiento as No_Doc,a.Annio,a.Tipo,a.Fec_Mov as Fecha,a.Vta_Total as Monto,b.Descripcion", "b.NoCuenta='" & Me.txtCodPrestamo.Text.Trim & "' and a.Estado<>'A' and b.Total_Vta=0", "cast(a.IdMovimiento as int) asc", sUsuario, sPassword, sSucursal)
                frm.Datos = ds
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim = "" Then
                ElseIf frm.Resultado.Trim <> "" Then
                    pFecha = CDate(frm.Resultado4.Trim)
                    Me.txtNoDocumento.Text = frm.Resultado.Trim
                    Me.txtAnio.Text = frm.Resultado2.Trim
                    Me.txtTipo.Text = frm.Resultado3.Trim
                    Me.C1NEMonto.Value = frm.Resultado5.Trim
                    Me.txtOrigen.Text = "C"
                    Me.dtpDia.Value = pFecha
                End If
            ElseIf Me.rbTransferencia.Checked = True Then
                ds = oAhorro.ConsultarTransferencia("a.CodTransferencia as No_Doc,a.Fecha,b.Valor as Monto,a.Observacion", "b.NoCuenta='" & Me.txtCodPrestamo.Text.Trim & "' and a.Estado='N'", "a.Fecha desc", "3", sUsuario, sPassword, sSucursal)
                frm.Datos = ds
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim = "" Then
                ElseIf frm.Resultado.Trim <> "" Then
                    pFecha = CDate(frm.Resultado2.Trim)
                    Me.txtNoDocumento.Text = frm.Resultado.Trim
                    Me.txtAnio.Text = 0
                    Me.txtTipo.Text = ""
                    Me.txtOrigen.Text = "T"
                    Me.C1NEMonto.Value = frm.Resultado3.Trim
                    Me.dtpDia.Value = pFecha
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub


    Private Sub btnReimpresion1_Click(sender As Object, e As EventArgs) Handles btnReimpresion1.Click

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oCred As wrPrestamo.wsLibPrest, ds As New Data.DataSet ' , dr As DataRow
        Try
            oCred = New wrPrestamo.wsLibPrest
            If Me.txtCodPrestamo.Text.Trim = "" Then
                ds = oCred.ConsultarPRReversiones("CodReversion,CodPrestamo,Fecha as FechaAplicacion,TipoMov,Monto,NoDocumento,FechaAplicacion", "", "FechaAplicacion desc", sUsuario, sPassword, sSucursal)
            Else
                ds = oCred.ConsultarPRReversiones("CodReversion,CodPrestamo,Fecha as FechaAplicacion,TipoMov,Monto,NoDocumento,FechaAplicacion", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "FechaAplicacion desc", sUsuario, sPassword, sSucursal)
            End If
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                Me.txtCodReversion.Text = frm.Resultado.Trim
                Me.btnImprimir1.Enabled = True
                Me.btProcesar1.Enabled = False
                pReimpresion = True
                If frm.Resultado4.Trim = "C" Then
                    Me.rbCargo.Checked = True
                ElseIf frm.Resultado4.Trim = "A" Then
                    Me.rbAbono.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet, pResp As String, oItem As New wrCaja.wsLibCaja, oApp As New wrAdmin.wsLibAdmin ', pAplicaAhorro As Boolean, pAplicaAport As Boolean, drTemp As DataRow, pCampos As String
            Me.Cursor = Cursors.WaitCursor
            If Trim(Me.txtCodPrestamo.Text) = "" Or Val(Me.C1NEMonto.Value) = 0 Or Trim(Me.txtNoDocumento.Text) = "" Then Exit Sub
            If Me.pTipoOper.Trim = "" Then Exit Sub
            pCodReversion = "RM" & Me.pTipoOper & Format(Month(dtpDia.Value.Date), "00") & Year(dtpDia.Value.Date) & oCred.CorrelativoReversion(sUsuario, sPassword, sSucursal)
            Me.txtCodReversion.Text = pCodReversion
            pResp = oCred.ReversionCobranza(pCodReversion, (Trim(txtCodPrestamo.Text)), dtpDia.Value.Date, Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text), txtObs.Text.Trim, "R", "", 0, sUsuario, sPassword, sSucursal)
            Me.Cursor = Cursors.Default
            MessageBox.Show("Aplicación Valor / Fecha procesada con éxito.", "Aplicaciones Valor Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnImprimir1.Enabled = True
            Me.btProcesar1.Enabled = False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
            ds = oPrest.Comprobante_ReversionesCB(Me.txtCodReversion.Text.Trim, pTipoOper.Trim, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 112, 0)
            ofrm.ShowDialog()
            Limpiar()
            Me.btProcesar1.Enabled = True
            Me.btnImprimir1.Enabled = False

            If pReimpresion = True Then
                Me.btnImprimir1.Enabled = False
                Me.btProcesar1.Enabled = True
                pReimpresion = False
            End If
            rbAbono_CheckedChanged(sender, e)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rbReversion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReversion.CheckedChanged
        If Me.rbReversion.Checked = True Then
            Me.txtNoDocumento.ReadOnly = False
            Me.dtpDia.Enabled = True
            Me.C1NEMonto.Enabled = True
        Else
            Me.txtNoDocumento.ReadOnly = True
            Me.dtpDia.Enabled = False
            Me.C1NEMonto.Enabled = False
        End If
    End Sub




End Class