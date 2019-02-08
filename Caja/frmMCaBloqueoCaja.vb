Public Class frmMCaBloqueoCaja
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Private ofrm As frmCAFactura

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtCajero)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cód. Bloqueo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Código Usuario:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(152, 48)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(144, 22)
        Me.txtPassword.TabIndex = 0
        '
        'txtCajero
        '
        Me.txtCajero.BackColor = System.Drawing.Color.White
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(152, 16)
        Me.txtCajero.MaxLength = 20
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(144, 22)
        Me.txtCajero.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(276, 149)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 28)
        Me.btnLogin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Bloquear"
        Me.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLogin.UseSelectable = True
        Me.btnLogin.UseStyleColors = True
        '
        'frmMCaBloqueoCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(374, 207)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCaBloqueoCaja"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Bloqueo de Terminal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property frm() As frmCAFactura
        Get
            Return ofrm
        End Get
        Set(ByVal Value As frmCAFactura)
            ofrm = Value
        End Set
    End Property



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim oItem As New wrCaja.wsLibCaja, ds As New DataSet, dsCaja As New DataSet, vCodCajero As String
        Dim Filas As Data.DataRowCollection
        Try
            ds = oItem.ConsultarCajerosPs("*", "Usuario='" & Me.txtCajero.Text.Trim & "' and Activo='1'", Me.txtPassword.Text.Trim, "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                vCodCajero = Filas.Item(0)("CodCajero")
                'Verificar si es el código de cajero que aperturó la caja
                dsCaja = oItem.ConsultarAperturaCaja("*", "FechaApertura='" & Date.Now.ToShortDateString & "' and CodCajero=" & vCodCajero & " and CajaCerrada<>'1'", "", sUsuario, sPassword, sSucursal)
                Filas = dsCaja.Tables(0).Rows()
                If Filas.Count > 0 Then
                    'If Me.btnCancelar.Visible = False Then
                    '    frm.Show()
                    '    Me.Dispose()
                    'Else
                    Me.Text = "Desbloqueo de Terminal"
                        Me.btnLogin.Text = "&Desbloquear"
                        Me.txtPassword.Text = ""
                        frm.Hide()
                    '    'Me.btnCancelar.Visible = False
                    'End If
                Else
                    MessageBox.Show("Acceso denegado para este Usuario.", "Bloqueo de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                End If
            Else

                MessageBox.Show("El Usuario no existe o no está activo, verifíque.", "Bloqeuo de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
