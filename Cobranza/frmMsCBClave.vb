Public Class frmMsCBClave
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents txtClaveAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarClave As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtClaveAnterior = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmarClave = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtClaveAnterior
        '
        Me.txtClaveAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClaveAnterior.Location = New System.Drawing.Point(110, 84)
        Me.txtClaveAnterior.MaxLength = 20
        Me.txtClaveAnterior.Name = "txtClaveAnterior"
        Me.txtClaveAnterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAnterior.Size = New System.Drawing.Size(305, 20)
        Me.txtClaveAnterior.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 1010
        Me.Label3.Text = "Clave anterior:"
        '
        'txtConfirmarClave
        '
        Me.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmarClave.Location = New System.Drawing.Point(110, 136)
        Me.txtConfirmarClave.MaxLength = 20
        Me.txtConfirmarClave.Name = "txtConfirmarClave"
        Me.txtConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarClave.Size = New System.Drawing.Size(305, 20)
        Me.txtConfirmarClave.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 30)
        Me.Label6.TabIndex = 1009
        Me.Label6.Text = "Confirmar Nueva Clave:"
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Location = New System.Drawing.Point(110, 110)
        Me.txtClave.MaxLength = 20
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(305, 20)
        Me.txtClave.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1008
        Me.Label1.Text = "Nueva Clave:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.CausesValidation = False
        Me.txtUsuario.Location = New System.Drawing.Point(110, 60)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(305, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1007
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(340, 164)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1012
        Me.btnGuardar1.Text = "Aceptar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCBClave
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(441, 215)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtClaveAnterior)
        Me.Controls.Add(Me.txtConfirmarClave)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(441, 215)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(441, 215)
        Me.Name = "frmMsCBClave"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private vUsuario As String, vCodigo As String

    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal Value As String)
            vUsuario = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal Value As String)
            vCodigo = Value
        End Set
    End Property

    Private Sub frmMsCambioClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsuario.Text = Me.vUsuario.Trim
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCaja As New wrCredito.wsLibCred
            If Me.txtClave.Text.Trim <> Me.txtConfirmarClave.Text.Trim Then
                MessageBox.Show("Las claves no coinciden, verifíque.", "Gestores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If oCaja.VerificaGestor(Me.vCodigo, Me.txtClaveAnterior.Text, sUsuario, sPassword, sSucursal) <> "" Then
                MessageBox.Show("Clave anterior no coincide, verifíque.", "Gestores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If oCaja.ModificaClaveGestores(Me.vCodigo, Me.txtClave.Text.Trim, sUsuario, sPassword, sSucursal) = True Then
                Me.Dispose()
            Else
                MessageBox.Show("El registro no ha sido actualizado, verifíque.", "Gestores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


End Class