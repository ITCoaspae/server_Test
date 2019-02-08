Public Class frmRepOrdenDescuento
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private pPrestamo As System.Data.DataSet, vNumSol As String, vNumReporte As String, vTitulo As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDirigidoA As System.Windows.Forms.TextBox
    Friend WithEvents txtCopiaA As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoCopiaA As System.Windows.Forms.TextBox
    Friend WithEvents chkCopia As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtEfectivo As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtEfectivo = New System.Windows.Forms.DateTimePicker()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescCargo = New System.Windows.Forms.TextBox()
        Me.txtCodCargo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkCopia = New System.Windows.Forms.CheckBox()
        Me.txtCargoCopiaA = New System.Windows.Forms.TextBox()
        Me.txtCopiaA = New System.Windows.Forms.TextBox()
        Me.txtDirigidoA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtEfectivo)
        Me.GroupBox1.Controls.Add(Me.c1nCuota)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(616, 248)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(616, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione datos del Reporte"
        '
        'dtEfectivo
        '
        Me.dtEfectivo.CustomFormat = "MMMM/yyyy"
        Me.dtEfectivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEfectivo.Location = New System.Drawing.Point(480, 64)
        Me.dtEfectivo.Name = "dtEfectivo"
        Me.dtEfectivo.Size = New System.Drawing.Size(128, 20)
        Me.dtEfectivo.TabIndex = 3
        '
        'c1nCuota
        '
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.CustomFormat = "###,###,##0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nCuota.Location = New System.Drawing.Point(216, 64)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCuota.ShowDropDownButton = False
        Me.c1nCuota.ShowUpDownButtons = False
        Me.c1nCuota.Size = New System.Drawing.Size(88, 21)
        Me.c1nCuota.TabIndex = 2
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(168, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Cuota:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(64, 64)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescCargo)
        Me.GroupBox2.Controls.Add(Me.txtCodCargo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkCopia)
        Me.GroupBox2.Controls.Add(Me.txtCargoCopiaA)
        Me.GroupBox2.Controls.Add(Me.txtCopiaA)
        Me.GroupBox2.Controls.Add(Me.txtDirigidoA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 144)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Orden de Descuento:"
        '
        'txtDescCargo
        '
        Me.txtDescCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCargo.Location = New System.Drawing.Point(80, 112)
        Me.txtDescCargo.Name = "txtDescCargo"
        Me.txtDescCargo.ReadOnly = True
        Me.txtDescCargo.Size = New System.Drawing.Size(416, 20)
        Me.txtDescCargo.TabIndex = 182
        '
        'txtCodCargo
        '
        Me.txtCodCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCargo.Location = New System.Drawing.Point(8, 112)
        Me.txtCodCargo.MaxLength = 10
        Me.txtCodCargo.Name = "txtCodCargo"
        Me.txtCodCargo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCargo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "Cargo Firma Autorizado:"
        '
        'chkCopia
        '
        Me.chkCopia.Location = New System.Drawing.Point(8, 24)
        Me.chkCopia.Name = "chkCopia"
        Me.chkCopia.Size = New System.Drawing.Size(80, 16)
        Me.chkCopia.TabIndex = 0
        Me.chkCopia.Text = "Con &Copia"
        '
        'txtCargoCopiaA
        '
        Me.txtCargoCopiaA.Location = New System.Drawing.Point(304, 64)
        Me.txtCargoCopiaA.Name = "txtCargoCopiaA"
        Me.txtCargoCopiaA.Size = New System.Drawing.Size(288, 20)
        Me.txtCargoCopiaA.TabIndex = 3
        '
        'txtCopiaA
        '
        Me.txtCopiaA.Enabled = False
        Me.txtCopiaA.Location = New System.Drawing.Point(160, 24)
        Me.txtCopiaA.Name = "txtCopiaA"
        Me.txtCopiaA.Size = New System.Drawing.Size(256, 20)
        Me.txtCopiaA.TabIndex = 1
        '
        'txtDirigidoA
        '
        Me.txtDirigidoA.Location = New System.Drawing.Point(8, 64)
        Me.txtDirigidoA.Name = "txtDirigidoA"
        Me.txtDirigidoA.Size = New System.Drawing.Size(288, 20)
        Me.txtDirigidoA.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Dirigido A:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(304, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Institución:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(104, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Copia a:"
        '
        'txtAsociado
        '
        Me.txtAsociado.Location = New System.Drawing.Point(112, 32)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(400, 20)
        Me.txtAsociado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(112, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Asociado:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(16, 32)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(88, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "DUI Asociado:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(312, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 16)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Descuento efectivo a partir de:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(556, 317)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(83, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 224
        Me.MetroButton1.Text = "Reporte"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmRepOrdenDescuento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(657, 355)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepOrdenDescuento"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Orden de Descuento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

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
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.Orden_Descuento(Me.txtDui.Text.Trim, Me.c1nCuota.Value, Me.txtCopiaA.Text.Trim, Me.txtCargoCopiaA.Text.Trim, Me.txtDirigidoA.Text.Trim, Me.dtpFecha.Value, Me.txtCodCargo.Text.Trim, Me.dtEfectivo.Value, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 199, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRepPRDetallePrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub chkCopia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCopia.CheckedChanged
        If Me.chkCopia.Checked = True Then
            Me.txtCopiaA.Enabled = True
        Else
            Me.txtCopiaA.Text = ""
            Me.txtCopiaA.Enabled = False
        End If
    End Sub

    Private Sub txtCodCargo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCargo.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodCargo.Text = sResultado1
                Me.txtDescCargo.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

End Class