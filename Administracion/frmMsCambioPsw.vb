Public Class frmMsCambioPsw
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
    Friend WithEvents txtConfirmarClave As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClaveAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtConfirmarClave = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClaveAnterior = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtConfirmarClave
        '
        Me.txtConfirmarClave.BackColor = System.Drawing.Color.White
        Me.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmarClave.Location = New System.Drawing.Point(187, 157)
        Me.txtConfirmarClave.MaxLength = 20
        Me.txtConfirmarClave.Name = "txtConfirmarClave"
        Me.txtConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarClave.Size = New System.Drawing.Size(280, 22)
        Me.txtConfirmarClave.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 23)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Confirmar:"
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.White
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Location = New System.Drawing.Point(187, 127)
        Me.txtClave.MaxLength = 20
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(280, 22)
        Me.txtClave.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Nueva Clave:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.CausesValidation = False
        Me.txtUsuario.Location = New System.Drawing.Point(187, 69)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(280, 22)
        Me.txtUsuario.TabIndex = 1000
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Clave anterior:"
        '
        'txtClaveAnterior
        '
        Me.txtClaveAnterior.BackColor = System.Drawing.Color.White
        Me.txtClaveAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClaveAnterior.Location = New System.Drawing.Point(187, 97)
        Me.txtClaveAnterior.MaxLength = 20
        Me.txtClaveAnterior.Name = "txtClaveAnterior"
        Me.txtClaveAnterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAnterior.Size = New System.Drawing.Size(280, 22)
        Me.txtClaveAnterior.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(28, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(438, 15)
        Me.Label4.TabIndex = 1003
        Me.Label4.Text = "La contraseña debe tener al menos 8 caracteres, letras mayúsculas y números."
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(377, 213)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1004
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCambioPsw
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(485, 271)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmarClave)
        Me.Controls.Add(Me.txtClaveAnterior)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCambioPsw"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private vUsuario As String
    Private vReset As Boolean
    Public Property reset() As Boolean
        Get
            Return vReset
        End Get
        Set(ByVal value As Boolean)
            vReset = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal Value As String)
            vUsuario = Value
        End Set
    End Property



    Private Sub frmMsCambioPsw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsuario.Text = Me.vUsuario.Trim
    End Sub


    Protected Function isPasswordValid() As Boolean
        If Me.txtClave.Text.Trim <> Me.txtConfirmarClave.Text.Trim Then
            Me.txtClave.Text = ""
            Me.txtConfirmarClave.Text = ""
            MsgBox("Las contraseñas ingresadas no coinciden", MsgBoxStyle.Critical, "")

            Return False
            Exit Function
        End If
        If Me.txtClaveAnterior.Text.Trim = Me.txtClave.Text.Trim Then
            Me.txtClave.Text = ""
            Me.txtConfirmarClave.Text = ""
            MsgBox("No puede ingresar la misma contraseña", MsgBoxStyle.Critical, "")
            Return False
            Exit Function
        End If
        If Me.txtClave.Text.Length < 8 Then
            Me.txtClave.Text = ""
            Me.txtConfirmarClave.Text = ""
            MsgBox("La longitud de la contraseña debe ser mayor o igual a 8 caracteres", MsgBoxStyle.Critical)
        End If
        Dim existeNumero As Boolean
        Dim existeLetraMayuscula As Boolean

        For Each c As Char In txtClave.Text
            If Char.IsDigit(c) Then
                existeNumero = True
                Continue For
            End If
            If c = c.ToString.ToUpper Then
                existeLetraMayuscula = True
            End If
        Next
        If existeNumero = False Then
            Me.txtClave.Text = ""
            Me.txtConfirmarClave.Text = ""
            MsgBox("La contraseña debe contener Números", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If existeLetraMayuscula = False Then
            Me.txtClave.Text = ""
            Me.txtConfirmarClave.Text = ""
            MsgBox("La contraseña debe contener letras mayusculas", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin
            If vReset = False Then
                If isPasswordValid() = True Then
                    If oAdm.VerificaUsuario(Me.vUsuario, Me.txtClaveAnterior.Text, sUsuario, sPassword, sSucursal) <> "" Then
                        MessageBox.Show("Clave anterior no coincide, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If oAdm.ModificarClave("Usuario='" & Me.vUsuario & "'", Me.txtClave.Text.Trim, sUsuario, sPassword, sSucursal, vReset) = True Then
                        MsgBox("El cambio de contraseña se realizo exitosamente.", MsgBoxStyle.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("El Usuario no ha sido actualizado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                If oAdm.ModificarClave("Usuario='" & Me.vUsuario & "'", Me.txtClave.Text.Trim, sUsuario, sPassword, sSucursal, vReset) = True Then
                    MsgBox("El cambio de contraseña se realizo exitosamente.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MessageBox.Show("El Usuario no ha sido actualizado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If


        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class