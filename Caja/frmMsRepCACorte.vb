Public Class frmMsRepCACorte
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
    Friend WithEvents c1txtNoCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nSubtotalCheque As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSubtotalEfectivo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1txtNoCaja = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1nSubtotalCheque = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSubtotalEfectivo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nSubtotalCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSubtotalEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1txtNoCaja
        '
        Me.c1txtNoCaja.BackColor = System.Drawing.Color.White
        Me.c1txtNoCaja.Location = New System.Drawing.Point(141, 89)
        Me.c1txtNoCaja.Name = "c1txtNoCaja"
        Me.c1txtNoCaja.Size = New System.Drawing.Size(144, 20)
        Me.c1txtNoCaja.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Número de Caja:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(141, 63)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(144, 20)
        Me.dtpFecha.TabIndex = 21
        Me.dtpFecha.Value = New Date(2006, 8, 19, 10, 44, 20, 248)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Fecha:"
        '
        'c1nSubtotalCheque
        '
        Me.c1nSubtotalCheque.BackColor = System.Drawing.Color.White
        Me.c1nSubtotalCheque.CustomFormat = "###,###,##0.00"
        Me.c1nSubtotalCheque.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nSubtotalCheque.Location = New System.Drawing.Point(141, 144)
        Me.c1nSubtotalCheque.Name = "c1nSubtotalCheque"
        Me.c1nSubtotalCheque.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubtotalCheque.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubtotalCheque.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubtotalCheque.Size = New System.Drawing.Size(144, 18)
        Me.c1nSubtotalCheque.TabIndex = 29
        Me.c1nSubtotalCheque.Tag = Nothing
        Me.c1nSubtotalCheque.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSubtotalCheque.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nSubtotalEfectivo
        '
        Me.c1nSubtotalEfectivo.BackColor = System.Drawing.Color.White
        Me.c1nSubtotalEfectivo.CustomFormat = "###,###,##0.00"
        Me.c1nSubtotalEfectivo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nSubtotalEfectivo.Location = New System.Drawing.Point(141, 118)
        Me.c1nSubtotalEfectivo.Name = "c1nSubtotalEfectivo"
        Me.c1nSubtotalEfectivo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubtotalEfectivo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubtotalEfectivo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubtotalEfectivo.Size = New System.Drawing.Size(144, 18)
        Me.c1nSubtotalEfectivo.TabIndex = 28
        Me.c1nSubtotalEfectivo.Tag = Nothing
        Me.c1nSubtotalEfectivo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSubtotalEfectivo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Total Cheque:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Efectivo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(273, 170)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1016
        Me.btnGuardar1.Text = "Mostrar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsRepCACorte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(371, 225)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.c1nSubtotalCheque)
        Me.Controls.Add(Me.c1nSubtotalEfectivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c1txtNoCaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsRepCACorte"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Corte de Movimientos de Caja"
        CType(Me.c1nSubtotalCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSubtotalEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsRepCACorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim ds As New DataSet
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
            ds = oCaja.CorteMovCaja(Me.dtpFecha.Value, Me.c1txtNoCaja.Text.Trim, Me.c1nSubtotalEfectivo.Value, Me.c1nSubtotalCheque.Value, sUsuario, sPassword, sSucursal)
            'ds.WriteXml("C:\ds.xml")
            Dim ofrm As New frmVisor(ds, 30, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
