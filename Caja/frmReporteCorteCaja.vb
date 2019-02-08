Public Class frmReporteCorteCaja
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCajero As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents c1txtNoCaja As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1nSubtotalCheque As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSubtotalEfectivo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodCajero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.c1txtNoCaja = New C1.Win.C1Input.C1TextBox()
        Me.c1nSubtotalCheque = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSubtotalEfectivo = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSubtotalCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSubtotalEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(203, 20)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(283, 20)
        Me.txtNombre.TabIndex = 112
        '
        'txtCodCajero
        '
        Me.txtCodCajero.BackColor = System.Drawing.Color.White
        Me.txtCodCajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCajero.Location = New System.Drawing.Point(118, 20)
        Me.txtCodCajero.MaxLength = 10
        Me.txtCodCajero.Name = "txtCodCajero"
        Me.txtCodCajero.Size = New System.Drawing.Size(80, 20)
        Me.txtCodCajero.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Código Cajero:"
        '
        'c1txtNoCaja
        '
        Me.c1txtNoCaja.BackColor = System.Drawing.Color.White
        Me.c1txtNoCaja.DataType = GetType(Short)
        Me.c1txtNoCaja.Location = New System.Drawing.Point(118, 53)
        Me.c1txtNoCaja.Name = "c1txtNoCaja"
        Me.c1txtNoCaja.Size = New System.Drawing.Size(72, 20)
        Me.c1txtNoCaja.TabIndex = 1
        Me.c1txtNoCaja.Tag = Nothing
        '
        'c1nSubtotalCheque
        '
        Me.c1nSubtotalCheque.BackColor = System.Drawing.Color.White
        Me.c1nSubtotalCheque.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSubtotalCheque.Location = New System.Drawing.Point(359, 82)
        Me.c1nSubtotalCheque.Name = "c1nSubtotalCheque"
        Me.c1nSubtotalCheque.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubtotalCheque.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubtotalCheque.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubtotalCheque.ShowDropDownButton = False
        Me.c1nSubtotalCheque.ShowUpDownButtons = False
        Me.c1nSubtotalCheque.Size = New System.Drawing.Size(127, 20)
        Me.c1nSubtotalCheque.TabIndex = 4
        Me.c1nSubtotalCheque.Tag = Nothing
        Me.c1nSubtotalCheque.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nSubtotalEfectivo
        '
        Me.c1nSubtotalEfectivo.BackColor = System.Drawing.Color.White
        Me.c1nSubtotalEfectivo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSubtotalEfectivo.Location = New System.Drawing.Point(118, 81)
        Me.c1nSubtotalEfectivo.Name = "c1nSubtotalEfectivo"
        Me.c1nSubtotalEfectivo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubtotalEfectivo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubtotalEfectivo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubtotalEfectivo.ShowDropDownButton = False
        Me.c1nSubtotalEfectivo.ShowUpDownButtons = False
        Me.c1nSubtotalEfectivo.Size = New System.Drawing.Size(122, 20)
        Me.c1nSubtotalEfectivo.TabIndex = 3
        Me.c1nSubtotalEfectivo.Tag = Nothing
        Me.c1nSubtotalEfectivo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(399, 55)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2006, 8, 19, 10, 44, 20, 248)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Número de Caja:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(273, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total Cheque:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total Efectivo:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(349, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCodCajero)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.c1txtNoCaja)
        Me.GroupBox1.Controls.Add(Me.c1nSubtotalCheque)
        Me.GroupBox1.Controls.Add(Me.c1nSubtotalEfectivo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(458, 187)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1019
        Me.btnGuardar1.Text = "Mostrar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmReporteCorteCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(558, 244)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(558, 244)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 244)
        Me.Name = "frmReporteCorteCaja"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte Corte de Caja (Detalle de cheques)"
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSubtotalCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSubtotalEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtCodCajero_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCajero.DoubleClick

        Dim ofrm As New frmAGenerico

        Try
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja, ds As New Data.DataSet
            ds = oCaja.ConsultarCajeros("*", "", "CodCajero", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Cajeros"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCajero.Text = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cajeros - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub frmReporteCorteCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim ds As New Data.DataSet
        Dim oItem As New wrCaja.wsLibCaja
        Dim pFecha As Date = Me.dtpFecha.Value.ToShortDateString
        Dim pSubTotalEfectivo As Double = Me.c1nSubtotalEfectivo.Value
        Dim pSubTotalCheque As Double = Me.c1nSubtotalCheque.Value
        'Dim pFiltroCaja, pFiltroCajero As String

        Try
            If Me.txtCodCajero.Text.Trim = "" Then Exit Sub

            ds = oItem.ReporteCorteCaja(pFecha, "", "NoCaja='" & Trim(Me.c1txtNoCaja.Value) & "'", "CodCajero=" & Trim(Me.txtCodCajero.Text) & "", pSubTotalEfectivo, pSubTotalCheque, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 19, 0)
            ofrm.ShowDialog()

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
