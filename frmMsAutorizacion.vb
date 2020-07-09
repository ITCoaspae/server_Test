Public Class frmMsAutorizacion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vAutoriza As Boolean, pNumPrograma As String, pUsuario As String, pTipoPermiso As String, pPassword As String
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Usuario:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(119, 92)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(234, 21)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(119, 60)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(234, 21)
        Me.txtUsuario.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(273, 119)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 32)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 32
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'frmMsAutorizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(382, 182)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(382, 182)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(382, 182)
        Me.Name = "frmMsAutorizacion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Autorización de Supervisor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property TipoPermiso() As String
        Get
            Return pTipoPermiso
        End Get
        Set(ByVal Value As String)
            pTipoPermiso = Value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return pUsuario
        End Get
        Set(ByVal Value As String)
            pUsuario = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return pPassword
        End Get
        Set(ByVal Value As String)
            pPassword = Value
        End Set
    End Property

    Public Property NumPrograma() As String
        Get
            Return pNumPrograma
        End Get
        Set(ByVal Value As String)
            pNumPrograma = Value
        End Set
    End Property

    Public Property Autoriza() As Boolean
        Get
            Return vAutoriza
        End Get
        Set(ByVal Value As Boolean)
            vAutoriza = Value
            vAutoriza = False
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vAutoriza = False
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, vResponse As String, ds As New DataSet, dr As DataRow, vResp As String, dv As New DataView
            vResponse = oAdm.VerificaUsuario(Me.txtUsuario.Text.Trim, Me.txtPassword.Text.Trim, sUsuario, sPassword, sSucursal)
            If vResponse = "" Then
                pUsuario = Me.txtUsuario.Text.Trim
                pPassword = Me.txtPassword.Text.Trim
                If pTipoPermiso = "P" Then 'Permiso a nivel de Procesos
                    vAutoriza = oAdm.VerficaDerechos(pNumPrograma, pUsuario, pPassword, sSucursal)
                    Me.Hide()
                ElseIf pTipoPermiso = "M" Then 'Permiso a nivel de Menú
                    Dim dsPrivilegios As New DataSet
                    ds = oAdm.ConsultarUsuarioxRol("CodRol", "a.Usuario='" & Me.txtUsuario.Text.Trim & "'", "a.Usuario", sUsuario, sPassword, sSucursal)
                    For Each dr In ds.Tables(0).Rows
                        dsPrivilegios = oAdm.GeneraMatrizProgramas(dr("CodRol"), pUsuario, pPassword, sSucursal)
                        dv = New DataView(dsPrivilegios.Tables(0))
                        dv.RowFilter = "Num_Programa='" & pNumPrograma & "'"
                        If dv.Count > 0 Then
                            vAutoriza = True
                            pUsuario = Me.txtUsuario.Text.Trim
                            Me.Hide()
                        Else
                            vAutoriza = False
                            Me.Hide()
                        End If
                    Next
                End If
            Else
                MessageBox.Show(vResponse, "Autenticación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                'vAutoriza = False
                'Me.txtPassword.Text = ""
                'Me.txtPassword.Focus()
                vAutoriza = False
                Me.Dispose()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            vAutoriza = False
            Me.Dispose()
        End Try
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.txtPassword.Focus()
            vAutoriza = False
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnAceptar_Click(sender, e)

        End If
    End Sub

    Private Sub frmMsAutorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
