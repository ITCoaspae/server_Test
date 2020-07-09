Public Class frmMsAhProvisiones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodCuenta As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodCuenta = New System.Windows.Forms.TextBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(260, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "al"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(286, 80)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(106, 22)
        Me.dtpR2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de Cuenta:"
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.Enabled = False
        Me.txtCodCuenta.Location = New System.Drawing.Point(106, 141)
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.Size = New System.Drawing.Size(286, 22)
        Me.txtCodCuenta.TabIndex = 4
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(26, 108)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(285, 19)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todas las Cuentas"
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(68, 80)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(105, 22)
        Me.dtpR1.TabIndex = 0
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(277, 169)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(115, 33)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 210
        Me.MetroButton3.Text = "Procesar"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'frmMsAhProvisiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(432, 255)
        Me.Controls.Add(Me.txtCodCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpR2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpR1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhProvisiones"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cálculo de Provisión - Ahorros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = False Then
            Me.txtCodCuenta.Enabled = True
        Else
            Me.txtCodCuenta.Enabled = False
        End If
    End Sub



    Private Sub frmMsAhProvisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
    End Sub



    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If (MsgBox("¿Desea realizar este proceso?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Dim resultado As String
                Dim todas As Integer
                If chkTodos.Checked = True Then
                    todas = 1
                Else
                    todas = 0
                End If
                resultado = ahorro.procesarProvisionAhorro(todas, dtpR1.Value.ToShortDateString, dtpR2.Value.ToShortDateString, txtCodCuenta.Text)
                If resultado.Length > 0 Then
                    MsgBox(resultado, MsgBoxStyle.Information)
                Else
                     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMsAhProvisiones_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class