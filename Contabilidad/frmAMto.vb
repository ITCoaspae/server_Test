Public Class frmAMto
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private vIdCuenta As String, vNivel As Integer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents nudNivel As NumericUpDown
    Friend WithEvents cmbTipoCuenta As ComboBox
    Friend WithEvents txtCtaDependencia As TextBox
    Friend WithEvents cmbFinal As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnBuscar2 As Button
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    'Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents txtIdCuenta As MetroFramework.Controls.MetroTextBox
    'Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    'Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    'Friend WithEvents nudNivel As NumericUpDown
    'Friend WithEvents cmbTipoCuenta As MetroFramework.Controls.MetroComboBox
    'Friend WithEvents btnBuscar2 As MetroFramework.Controls.MetroButton
    'Friend WithEvents cmbFinal As MetroFramework.Controls.MetroComboBox
    'Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    'Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    'Friend WithEvents txtCtaDependencia As MetroFramework.Controls.MetroTextBox

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

    'Requerido por el Diseñador de Windows Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.nudNivel = New System.Windows.Forms.NumericUpDown()
        Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.txtCtaDependencia = New System.Windows.Forms.TextBox()
        Me.cmbFinal = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBuscar2 = New System.Windows.Forms.Button()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cta. Dependencia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Final"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(127, 57)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(129, 20)
        Me.txtIdCuenta.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 83)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(378, 20)
        Me.txtDescripcion.TabIndex = 7
        '
        'nudNivel
        '
        Me.nudNivel.Location = New System.Drawing.Point(127, 109)
        Me.nudNivel.Name = "nudNivel"
        Me.nudNivel.Size = New System.Drawing.Size(120, 20)
        Me.nudNivel.TabIndex = 8
        '
        'cmbTipoCuenta
        '
        Me.cmbTipoCuenta.FormattingEnabled = True
        Me.cmbTipoCuenta.Location = New System.Drawing.Point(127, 135)
        Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
        Me.cmbTipoCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoCuenta.TabIndex = 9
        '
        'txtCtaDependencia
        '
        Me.txtCtaDependencia.Location = New System.Drawing.Point(127, 162)
        Me.txtCtaDependencia.Name = "txtCtaDependencia"
        Me.txtCtaDependencia.Size = New System.Drawing.Size(129, 20)
        Me.txtCtaDependencia.TabIndex = 10
        '
        'cmbFinal
        '
        Me.cmbFinal.FormattingEnabled = True
        Me.cmbFinal.Location = New System.Drawing.Point(126, 188)
        Me.cmbFinal.Name = "cmbFinal"
        Me.cmbFinal.Size = New System.Drawing.Size(121, 21)
        Me.cmbFinal.TabIndex = 11
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(262, 57)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBuscar2
        '
        Me.btnBuscar2.Location = New System.Drawing.Point(262, 162)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscar2.TabIndex = 13
        Me.btnBuscar2.Text = "..."
        Me.btnBuscar2.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(349, 263)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 28)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(430, 263)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelar.UseSelectable = True
        Me.btnCancelar.UseStyleColors = True
        '
        'frmAMto
        '
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(528, 309)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbFinal)
        Me.Controls.Add(Me.txtCtaDependencia)
        Me.Controls.Add(Me.cmbTipoCuenta)
        Me.Controls.Add(Me.nudNivel)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(528, 309)
        Me.MinimumSize = New System.Drawing.Size(528, 309)
        Me.Name = "frmAMto"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Cuentas"
        CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property IdCuenta() As String
        Get
            IdCuenta = vIdCuenta
        End Get
        Set(ByVal Value As String)
            vIdCuenta = Value
        End Set
    End Property

    Public Property Nivel() As Integer
        Get
            Return vNivel
        End Get
        Set(ByVal Value As Integer)
            vNivel = Value
        End Set
    End Property
#End Region


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnCancelarOnClick()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        btnAceptarOnClick()
    End Sub

    Public Overridable Sub btnCancelarOnClick()

    End Sub

    Public Overridable Sub btnAceptarOnClick()

    End Sub

    Public Overridable Sub btnBuscarOnClick()

    End Sub

    Public Overridable Sub btnBuscar2OnClick()

    End Sub

    Public Overridable Sub txtIdCuentaKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub


    Public Sub Cerrar()
        Me.Close()
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        btnBuscarOnClick()
    End Sub

    Private Sub btnBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click
        btnBuscar2OnClick()
    End Sub

    Private Sub txtIdCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtIdCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuenta.KeyPress
        txtIdCuentaKeyPress(sender, e)
    End Sub
End Class
